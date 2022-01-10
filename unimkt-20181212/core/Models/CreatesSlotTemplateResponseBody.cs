// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CreatesSlotTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public CreatesSlotTemplateResponseBodyModel Model { get; set; }
        public class CreatesSlotTemplateResponseBodyModel : TeaModel {
            [NameInMap("AdSlotTemplateDescription")]
            [Validation(Required=false)]
            public string AdSlotTemplateDescription { get; set; }
            [NameInMap("AdSlotTemplateId")]
            [Validation(Required=false)]
            public string AdSlotTemplateId { get; set; }
            [NameInMap("AdSlotTemplateName")]
            [Validation(Required=false)]
            public string AdSlotTemplateName { get; set; }
            [NameInMap("AdSlotTemplatePic")]
            [Validation(Required=false)]
            public string AdSlotTemplatePic { get; set; }
            [NameInMap("AdSlotTemplatePreview")]
            [Validation(Required=false)]
            public string AdSlotTemplatePreview { get; set; }
            [NameInMap("AdSlotTemplateTitle")]
            [Validation(Required=false)]
            public string AdSlotTemplateTitle { get; set; }
            [NameInMap("AdSlotType")]
            [Validation(Required=false)]
            public string AdSlotType { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
