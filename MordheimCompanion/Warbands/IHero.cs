﻿namespace MordheimCompanion
{
    public interface IHero
    {
        public string Name {  get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Experiance { get; set; }

        public Skills Skills { get; set; }

    }

    public class Skills
    {
        private bool combat = false;
        private bool shooting = false;
        private bool academic = false;
        private bool strength = false;
        private bool speed = false;
    }
}