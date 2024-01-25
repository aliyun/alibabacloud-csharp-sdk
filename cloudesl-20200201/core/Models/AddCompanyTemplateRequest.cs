// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class AddCompanyTemplateRequest : TeaModel {
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        [NameInMap("EslSize")]
        [Validation(Required=false)]
        public string EslSize { get; set; }

        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParams { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("IfDefault")]
        [Validation(Required=false)]
        public bool? IfDefault { get; set; }

        [NameInMap("IfMember")]
        [Validation(Required=false)]
        public bool? IfMember { get; set; }

        [NameInMap("IfOutOfInventory")]
        [Validation(Required=false)]
        public bool? IfOutOfInventory { get; set; }

        [NameInMap("IfPromotion")]
        [Validation(Required=false)]
        public bool? IfPromotion { get; set; }

        [NameInMap("IfSourceCode")]
        [Validation(Required=false)]
        public bool? IfSourceCode { get; set; }

        [NameInMap("Layout")]
        [Validation(Required=false)]
        public int? Layout { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateSceneId")]
        [Validation(Required=false)]
        public string TemplateSceneId { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
