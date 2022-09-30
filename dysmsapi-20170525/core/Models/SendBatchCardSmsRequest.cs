// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchCardSmsRequest : TeaModel {
        [NameInMap("CardTemplateCode")]
        [Validation(Required=false)]
        public string CardTemplateCode { get; set; }

        [NameInMap("CardTemplateParamJson")]
        [Validation(Required=false)]
        public string CardTemplateParamJson { get; set; }

        [NameInMap("DigitalTemplateCode")]
        [Validation(Required=false)]
        public string DigitalTemplateCode { get; set; }

        [NameInMap("DigitalTemplateParamJson")]
        [Validation(Required=false)]
        public string DigitalTemplateParamJson { get; set; }

        [NameInMap("FallbackType")]
        [Validation(Required=false)]
        public string FallbackType { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("PhoneNumberJson")]
        [Validation(Required=false)]
        public string PhoneNumberJson { get; set; }

        [NameInMap("SignNameJson")]
        [Validation(Required=false)]
        public string SignNameJson { get; set; }

        [NameInMap("SmsTemplateCode")]
        [Validation(Required=false)]
        public string SmsTemplateCode { get; set; }

        [NameInMap("SmsTemplateParamJson")]
        [Validation(Required=false)]
        public string SmsTemplateParamJson { get; set; }

        [NameInMap("SmsUpExtendCodeJson")]
        [Validation(Required=false)]
        public string SmsUpExtendCodeJson { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateParamJson")]
        [Validation(Required=false)]
        public string TemplateParamJson { get; set; }

    }

}
