// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListMessagesResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMessagesResponseBodyData Data { get; set; }
        public class ListMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// 短信列表。
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListMessagesResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// 短信错误码。
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// 关联人群Id，未关联则为空。
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// 短信序列号。
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 外部拓展字段。
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// 手机号码。
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// 关联触达计划Id，未关联则为空。
                /// </summary>
                [NameInMap("ScheduleId")]
                [Validation(Required=false)]
                public string ScheduleId { get; set; }

                /// <summary>
                /// 签名名称。
                /// </summary>
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// 短信发送状态。
                /// - 0 : 发送中。
                /// - 1 : 发送成功。
                /// - 2 : 发送失败。
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// 模板号。
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

                /// <summary>
                /// 模板参数。
                /// </summary>
                [NameInMap("TemplateParams")]
                [Validation(Required=false)]
                public string TemplateParams { get; set; }

                /// <summary>
                /// 模板类型。
                /// - 0 : 验证码。
                /// - 1 : 短信通知。
                /// - 2 : 推广短信。
                /// </summary>
                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public int? TemplateType { get; set; }

            }

            /// <summary>
            /// 分页数，从1开始，默认为1。
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// 分页大小，默认为10。
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// 短信数量。
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
