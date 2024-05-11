// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class InputFile : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        [NameInMap("Album")]
        [Validation(Required=false)]
        public string Album { get; set; }

        [NameInMap("AlbumArtist")]
        [Validation(Required=false)]
        public string AlbumArtist { get; set; }

        [NameInMap("Artist")]
        [Validation(Required=false)]
        public string Artist { get; set; }

        [NameInMap("Composer")]
        [Validation(Required=false)]
        public string Composer { get; set; }

        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        [NameInMap("Figures")]
        [Validation(Required=false)]
        public List<InputFileFigures> Figures { get; set; }
        public class InputFileFigures : TeaModel {
            [NameInMap("FigureClusterId")]
            [Validation(Required=false)]
            public string FigureClusterId { get; set; }

            [NameInMap("FigureId")]
            [Validation(Required=false)]
            public string FigureId { get; set; }

            [NameInMap("FigureType")]
            [Validation(Required=false)]
            public string FigureType { get; set; }

        }

        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        [NameInMap("LatLong")]
        [Validation(Required=false)]
        public string LatLong { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        [NameInMap("Performer")]
        [Validation(Required=false)]
        public string Performer { get; set; }

        [NameInMap("ProduceTime")]
        [Validation(Required=false)]
        public string ProduceTime { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
