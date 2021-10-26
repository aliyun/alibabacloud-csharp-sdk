// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendSmsSmartRequest : TeaModel {
        [NameInMap("ExtendCode")]
        [Validation(Required=false)]
        public string ExtendCode { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("NumberType")]
        [Validation(Required=false)]
        public string NumberType { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public string PhoneNumbers { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateParam")]
        [Validation(Required=false)]
        public string TemplateParam { get; set; }

    }

}
