// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SmsReportRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<SmsReportRequestBody> Body { get; set; }
        public class SmsReportRequestBody : TeaModel {
            [NameInMap("biz_id")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("err_code")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            [NameInMap("err_msg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            [NameInMap("message_id")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            [NameInMap("out_id")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            [NameInMap("phone_number")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("report_time")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            [NameInMap("request_id")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("send_time")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            [NameInMap("sign_name")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            [NameInMap("sms_size")]
            [Validation(Required=false)]
            public string SmsSize { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("template_code")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

    }

}
