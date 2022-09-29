// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20170622.Models
{
    public class ModifyTemplateRequest : TeaModel {
        [NameInMap("FromType")]
        [Validation(Required=false)]
        public int? FromType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SmsContent")]
        [Validation(Required=false)]
        public string SmsContent { get; set; }

        [NameInMap("SmsType")]
        [Validation(Required=false)]
        public int? SmsType { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateNickName")]
        [Validation(Required=false)]
        public string TemplateNickName { get; set; }

        [NameInMap("TemplateSubject")]
        [Validation(Required=false)]
        public string TemplateSubject { get; set; }

        [NameInMap("TemplateText")]
        [Validation(Required=false)]
        public string TemplateText { get; set; }

    }

}
