// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SmsReportRequest : TeaModel {
        /// <summary>
        /// 请求参数的主体信息。
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<SmsReportRequestBody> Body { get; set; }
        public class SmsReportRequestBody : TeaModel {
            /// <summary>
            /// 发送回执ID，即发送流水号。
            /// </summary>
            [NameInMap("biz_id")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// 状态报告编码。
            /// </summary>
            [NameInMap("err_code")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            /// <summary>
            /// 状态报告说明。
            /// </summary>
            [NameInMap("err_msg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// 短信Id。调用发送接口SendMessage发送短信时，返回值中的Id字段。可使用短信Id在接口ListMessages查询具体的发送状态。
            /// </summary>
            [NameInMap("message_id")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// 外部拓展字段。
            /// </summary>
            [NameInMap("out_id")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// 手机号码。
            /// </summary>
            [NameInMap("phone_number")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// 状态报告时间。
            /// </summary>
            [NameInMap("report_time")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

            /// <summary>
            /// 短信批处理Id。调用发送接口SendMessage发送短信时，返回值中的RequestId字段。可使用短信批处理Id在接口ListMessages查询具体的发送状态。
            /// </summary>
            [NameInMap("request_id")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// 发送时间。
            /// </summary>
            [NameInMap("send_time")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// 签名。
            /// </summary>
            [NameInMap("sign_name")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            /// <summary>
            /// 短信长度。短信长度不超过70个字，按照一条短信计费；超过70个字，即为长短信，按照67字/条拆分成多条计费。
            /// </summary>
            [NameInMap("sms_size")]
            [Validation(Required=false)]
            public string SmsSize { get; set; }

            /// <summary>
            /// 是否接收成功。
            /// - true : 接收成功。
            /// - false : 接收失败。
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// 模板号。
            /// </summary>
            [NameInMap("template_code")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

    }

}
