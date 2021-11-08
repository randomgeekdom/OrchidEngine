using OrchidCavalry.Services;
using System;
using System.Collections.Generic;

namespace OrchidCavalry.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(IFileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }


        private readonly Selection selection = new Selection();
        private readonly IFileWriter fileWriter;

        public string Title => this.selection.Title;
        public string Body => this.selection.Body;

        public Dictionary<string, Func<Selection>> Options => this.selection.Options;


        //TODO: Replace this with deserilizing the game object
        //public async Task<MainViewModel> InitiateAsync()
        //{
        //    var vm = default(MainViewModel);

        //    var text = await this.fileWriter.ReadFileAsync("game.sav");

        //    if (!string.IsNullOrWhiteSpace(text))
        //    {
        //        return JsonConvert.DeserializeObject<MainViewModel>(text);
        //    }

        //    return new MainViewModel();
        //}
    }

}
