// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SmsUpRequest : TeaModel {
        /// <summary>
        /// 请求参数的主体信息。
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<SmsUpRequestBody> Body { get; set; }
        public class SmsUpRequestBody : TeaModel {
            /// <summary>
            /// 发送内容。
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 上行短信扩展号码，系统后台自动生成，不支持自定义传入。
            /// </summary>
            [NameInMap("dest_code")]
            [Validation(Required=false)]
            public string DestCode { get; set; }

            /// <summary>
            /// 手机号码。
            /// </summary>
            [NameInMap("phone_number")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// 发送时间。
            /// </summary>
            [NameInMap("send_time")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// 序列号。
            /// </summary>
            [NameInMap("sequence_id")]
            [Validation(Required=false)]
            public int? SequenceId { get; set; }

            /// <summary>
            /// 签名信息。
            /// </summary>
            [NameInMap("sign_name")]
            [Validation(Required=false)]
            public string SignName { get; set; }

        }

    }

}
