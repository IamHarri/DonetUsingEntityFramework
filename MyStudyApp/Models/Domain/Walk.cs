﻿namespace MyStudyApp.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public  double Length { get; set; }

        public  Guid RegionID { get; set; }
        public Guid WalkDifficultyId  { get; set; }
        
        // Navigationi properties

        public Region Region { get; set; }
        public WalkDifficulty   WalkDifficulty { get; set; }
    }
}
