/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20171030.Models
{
    public class DoDefineRegisterNotificationRequest : TeaModel {
        [NameInMap("accountTraceId")]
        [Validation(Required=false)]
        public string AccountTraceId { get; set; }

        [NameInMap("emailTemplate")]
        [Validation(Required=false)]
        public string EmailTemplate { get; set; }

        [NameInMap("emailTemplateParamsJsonString")]
        [Validation(Required=false)]
        public string EmailTemplateParamsJsonString { get; set; }

        [NameInMap("interrupt")]
        [Validation(Required=false)]
        public bool? Interrupt { get; set; }

        [NameInMap("invoker")]
        [Validation(Required=false)]
        public string Invoker { get; set; }

        [NameInMap("pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

        [NameInMap("smsTemplate")]
        [Validation(Required=false)]
        public string SmsTemplate { get; set; }

        [NameInMap("smsTemplateParamsJsonString")]
        [Validation(Required=false)]
        public string SmsTemplateParamsJsonString { get; set; }

    }

}
