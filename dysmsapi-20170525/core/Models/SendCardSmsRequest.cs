// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendCardSmsRequest : TeaModel {
        [NameInMap("CardObjects")]
        [Validation(Required=false)]
        public Dictionary<string, object> CardObjects { get; set; }

        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        [NameInMap("DigitalTemplateParam")]
        [Validation(Required=false)]
        public string DigitalTemplateParam { get; set; }

        [NameInMap("FallbackType")]
        [Validation(Required=false)]
        public string FallbackType { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        [NameInMap("SmsTemplateParam")]
        [Validation(Required=false)]
        public string SmsTemplateParam { get; set; }

        [NameInMap("SmsUpExtendCode")]
        [Validation(Required=false)]
        public string SmsUpExtendCode { get; set; }

    }

}
