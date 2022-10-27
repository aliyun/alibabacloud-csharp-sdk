// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTemplateGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeTemplateGroup")]
        [Validation(Required=false)]
        public GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup TranscodeTemplateGroup { get; set; }
        public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroup : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            [NameInMap("TranscodeTemplateList")]
            [Validation(Required=false)]
            public List<GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList> TranscodeTemplateList { get; set; }
            public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList : TeaModel {
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public string Audio { get; set; }

                [NameInMap("Clip")]
                [Validation(Required=false)]
                public string Clip { get; set; }

                [NameInMap("Container")]
                [Validation(Required=false)]
                public string Container { get; set; }

                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                [NameInMap("EncryptSetting")]
                [Validation(Required=false)]
                public string EncryptSetting { get; set; }

                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public string MuxConfig { get; set; }

                [NameInMap("PackageSetting")]
                [Validation(Required=false)]
                public string PackageSetting { get; set; }

                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                [NameInMap("SubtitleList")]
                [Validation(Required=false)]
                public string SubtitleList { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public string TransConfig { get; set; }

                [NameInMap("TranscodeFileRegular")]
                [Validation(Required=false)]
                public string TranscodeFileRegular { get; set; }

                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

                [NameInMap("WatermarkIds")]
                [Validation(Required=false)]
                public List<string> WatermarkIds { get; set; }

            }

        }

    }

}
