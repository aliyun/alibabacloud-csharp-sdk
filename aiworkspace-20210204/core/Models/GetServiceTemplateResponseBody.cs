// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetServiceTemplateResponseBody : TeaModel {
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("InferenceSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceSpec { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceTemplateDescription")]
        [Validation(Required=false)]
        public string ServiceTemplateDescription { get; set; }

        [NameInMap("ServiceTemplateDoc")]
        [Validation(Required=false)]
        public string ServiceTemplateDoc { get; set; }

        [NameInMap("ServiceTemplateId")]
        [Validation(Required=false)]
        public string ServiceTemplateId { get; set; }

        [NameInMap("ServiceTemplateName")]
        [Validation(Required=false)]
        public string ServiceTemplateName { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
