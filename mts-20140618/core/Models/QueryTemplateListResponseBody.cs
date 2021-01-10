// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryTemplateListResponseBody : TeaModel {
        [NameInMap("NonExistTids")]
        [Validation(Required=false)]
        public QueryTemplateListResponseBodyNonExistTids NonExistTids { get; set; }
        public class QueryTemplateListResponseBodyNonExistTids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public QueryTemplateListResponseBodyTemplateList TemplateList { get; set; }
        public class QueryTemplateListResponseBodyTemplateList : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<QueryTemplateListResponseBodyTemplateListTemplate> Template { get; set; }
            public class QueryTemplateListResponseBodyTemplateListTemplate : TeaModel {
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
                public QueryTemplateListResponseBodyTemplateListTemplateBitrateBnd BitrateBnd { get; set; }
                public class QueryTemplateListResponseBodyTemplateListTemplateBitrateBnd : TeaModel {
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

                [NameInMap("ResoPriority")]
                [Validation(Required=false)]
                public string ResoPriority { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
