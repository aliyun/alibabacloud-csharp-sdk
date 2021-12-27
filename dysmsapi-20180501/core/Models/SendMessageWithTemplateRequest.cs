// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SendMessageWithTemplateRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
