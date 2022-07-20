// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveTranscodeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateContentList")]
        [Validation(Required=false)]
        public List<ListLiveTranscodeTemplatesResponseBodyTemplateContentList> TemplateContentList { get; set; }
        public class ListLiveTranscodeTemplatesResponseBodyTemplateContentList : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfig TemplateConfig { get; set; }
            public class ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfig : TeaModel {
                [NameInMap("AudioParams")]
                [Validation(Required=false)]
                public ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigAudioParams AudioParams { get; set; }
                public class ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigAudioParams : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    [NameInMap("Samplerate")]
                    [Validation(Required=false)]
                    public string Samplerate { get; set; }

                }
                [NameInMap("VideoParams")]
                [Validation(Required=false)]
                public ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigVideoParams VideoParams { get; set; }
                public class ListLiveTranscodeTemplatesResponseBodyTemplateContentListTemplateConfigVideoParams : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    [NameInMap("Gop")]
                    [Validation(Required=false)]
                    public string Gop { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }
            };

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
