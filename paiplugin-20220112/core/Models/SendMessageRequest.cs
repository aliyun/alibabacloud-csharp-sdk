// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("OutIds")]
        [Validation(Required=false)]
        public List<string> OutIds { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        [NameInMap("SmsUpExtendCodes")]
        [Validation(Required=false)]
        public List<string> SmsUpExtendCodes { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public List<string> TemplateParams { get; set; }

    }

}
