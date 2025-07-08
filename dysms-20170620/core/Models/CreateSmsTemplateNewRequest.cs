// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class CreateSmsTemplateNewRequest : TeaModel {
        [NameInMap("AiTemplate")]
        [Validation(Required=false)]
        public long? AiTemplate { get; set; }

        [NameInMap("AiTemplateUuid")]
        [Validation(Required=false)]
        public string AiTemplateUuid { get; set; }

        [NameInMap("ApplicationSceneId")]
        [Validation(Required=false)]
        public long? ApplicationSceneId { get; set; }

        [NameInMap("ApplySource")]
        [Validation(Required=false)]
        public string ApplySource { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public List<string> MoreData { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OssKeys")]
        [Validation(Required=false)]
        public string OssKeys { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ProductUrl")]
        [Validation(Required=false)]
        public string ProductUrl { get; set; }

        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        [NameInMap("RelatedSignOrderId")]
        [Validation(Required=false)]
        public string RelatedSignOrderId { get; set; }

        [NameInMap("RelatedSignUsageName")]
        [Validation(Required=false)]
        public string RelatedSignUsageName { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RmdTemplateId")]
        [Validation(Required=false)]
        public long? RmdTemplateId { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateRule")]
        [Validation(Required=false)]
        public string TemplateRule { get; set; }

        [NameInMap("UserViewFileName")]
        [Validation(Required=false)]
        public string UserViewFileName { get; set; }

    }

}
