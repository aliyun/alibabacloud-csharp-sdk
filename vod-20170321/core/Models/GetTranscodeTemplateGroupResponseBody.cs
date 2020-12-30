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
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("TranscodeTemplateList")]
            [Validation(Required=false)]
            public List<GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList> TranscodeTemplateList { get; set; }
            public class GetTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupTranscodeTemplateList : TeaModel {
                public string Video { get; set; }
                public string Type { get; set; }
                public string TransConfig { get; set; }
                public string TranscodeTemplateId { get; set; }
                public string Rotate { get; set; }
                public string EncryptSetting { get; set; }
                public string TemplateName { get; set; }
                public string Audio { get; set; }
                public string Container { get; set; }
                public string TranscodeFileRegular { get; set; }
                public string Definition { get; set; }
                public string Clip { get; set; }
                public string PackageSetting { get; set; }
                public List<string> WatermarkIds { get; set; }
                public string SubtitleList { get; set; }
                public string MuxConfig { get; set; }
            }
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }
        };

    }

}
