// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchTemplateResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public SearchTemplateResponseBodyTemplateList TemplateList { get; set; }
        public class SearchTemplateResponseBodyTemplateList : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<SearchTemplateResponseBodyTemplateListTemplate> Template { get; set; }
            public class SearchTemplateResponseBodyTemplateListTemplate : TeaModel {
                [NameInMap("Bufsize")]
                [Validation(Required=false)]
                public string Bufsize { get; set; }

                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public string LongShortMode { get; set; }

                [NameInMap("Degrain")]
                [Validation(Required=false)]
                public string Degrain { get; set; }

                [NameInMap("BitrateBnd")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateBitrateBnd BitrateBnd { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateBitrateBnd : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public string Max { get; set; }
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public string Min { get; set; }
                };

                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                [NameInMap("Pad")]
                [Validation(Required=false)]
                public string Pad { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                [NameInMap("Crop")]
                [Validation(Required=false)]
                public string Crop { get; set; }

                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("Maxrate")]
                [Validation(Required=false)]
                public string Maxrate { get; set; }

                [NameInMap("MaxFps")]
                [Validation(Required=false)]
                public string MaxFps { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("Crf")]
                [Validation(Required=false)]
                public string Crf { get; set; }

                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("Preset")]
                [Validation(Required=false)]
                public string Preset { get; set; }

                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

            }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
