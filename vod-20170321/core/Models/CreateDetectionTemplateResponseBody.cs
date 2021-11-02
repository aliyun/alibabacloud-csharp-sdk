// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateDetectionTemplateResponseBody : TeaModel {
        [NameInMap("DetectionTemplate")]
        [Validation(Required=false)]
        public CreateDetectionTemplateResponseBodyDetectionTemplate DetectionTemplate { get; set; }
        public class CreateDetectionTemplateResponseBodyDetectionTemplate : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
