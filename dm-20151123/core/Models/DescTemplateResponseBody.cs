// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescTemplateResponseBody : TeaModel {
        [NameInMap("SmsType")]
        [Validation(Required=false)]
        public string SmsType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("TemplateText")]
        [Validation(Required=false)]
        public string TemplateText { get; set; }

        [NameInMap("SmsContent")]
        [Validation(Required=false)]
        public string SmsContent { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateNickName")]
        [Validation(Required=false)]
        public string TemplateNickName { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        [NameInMap("TemplateSubject")]
        [Validation(Required=false)]
        public string TemplateSubject { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

    }

}
