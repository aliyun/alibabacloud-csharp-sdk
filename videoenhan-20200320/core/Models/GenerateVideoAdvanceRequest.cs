// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class GenerateVideoAdvanceRequest : TeaModel {
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        [NameInMap("DurationAdaption")]
        [Validation(Required=false)]
        public bool? DurationAdaption { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<GenerateVideoAdvanceRequestFileList> FileList { get; set; }
        public class GenerateVideoAdvanceRequestFileList : TeaModel {
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public Stream FileUrlObject { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("Mute")]
        [Validation(Required=false)]
        public bool? Mute { get; set; }

        [NameInMap("PuzzleEffect")]
        [Validation(Required=false)]
        public bool? PuzzleEffect { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("SmartEffect")]
        [Validation(Required=false)]
        public bool? SmartEffect { get; set; }

        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        [NameInMap("TransitionStyle")]
        [Validation(Required=false)]
        public string TransitionStyle { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
