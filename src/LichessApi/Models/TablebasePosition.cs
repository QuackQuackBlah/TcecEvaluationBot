﻿namespace LichessApi.Models
{
    using Newtonsoft.Json;

    public class TablebasePosition
    {
        public bool Checkmate { get; set; }

        public bool Stalemate { get; set; }

        [JsonProperty("variant_win")]
        public bool VariantWin { get; set; }

        [JsonProperty("variant_loss")]
        public bool VariantLoss { get; set; }

        [JsonProperty("insufficient_material")]
        public bool InsufficientMaterial { get; set; }

        public int? Wdl { get; set; }

        public int? Dtz { get; set; }

        public int? Dtm { get; set; }

        public TablebaseMove[] Moves { get; set; }
    }
}
