// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTemplateListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of templates per page. Valid values: **1 to 50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried message templates.
        /// </summary>
        [NameInMap("SmsTemplateList")]
        [Validation(Required=false)]
        public List<QuerySmsTemplateListResponseBodySmsTemplateList> SmsTemplateList { get; set; }
        public class QuerySmsTemplateListResponseBodySmsTemplateList : TeaModel {
            /// <summary>
            /// The approval status of the message template. Valid values:
            /// 
            /// *   **AUDIT_STATE_INIT**: The message template is pending approval.
            /// *   **AUDIT_STATE_PASS**: The message template is approved.
            /// *   **AUDIT_STATE_NOT_PASS**: The message template is rejected. You can view the reason in the Reason response parameter.
            /// *   **AUDIT_STATE_CANCEL** or **AUDIT_SATE_CANCEL**: The approval is canceled.
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// The time when the message template was created. The time is in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The ticket ID.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// The type of the message template. We recommend that you specify this parameter. Valid values:
            /// 
            /// *   **0**: verification code
            /// *   **1**: notification message
            /// *   **2**: promotional message
            /// *   **3**: message sent to countries or regions outside the Chinese mainland
            /// *   **7**: digital message
            /// 
            /// > The template type is the same as the value of the TemplateType parameter in the AddSmsTemplate and ModifySmsTemplate operations.
            /// </summary>
            [NameInMap("OuterTemplateType")]
            [Validation(Required=false)]
            public int? OuterTemplateType { get; set; }

            /// <summary>
            /// The approval remarks.
            /// 
            /// *   If the value of AuditStatus is **AUDIT_STATE_PASS** or **AUDIT_STATE_INIT**, the value of Reason is No Approval Remarks.
            /// *   If the value of AuditStatus is **AUDIT_STATE_NOT_PASS**, the reason why the message template is rejected is returned.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public QuerySmsTemplateListResponseBodySmsTemplateListReason Reason { get; set; }
            public class QuerySmsTemplateListResponseBodySmsTemplateListReason : TeaModel {
                /// <summary>
                /// The time when the message template was rejected. Format: yyyy-MM-dd HH:mm:ss.
                /// </summary>
                [NameInMap("RejectDate")]
                [Validation(Required=false)]
                public string RejectDate { get; set; }

                /// <summary>
                /// The reason why the message template was rejected.
                /// </summary>
                [NameInMap("RejectInfo")]
                [Validation(Required=false)]
                public string RejectInfo { get; set; }

                /// <summary>
                /// The remarks about the rejection.
                /// </summary>
                [NameInMap("RejectSubInfo")]
                [Validation(Required=false)]
                public string RejectSubInfo { get; set; }

            }

            /// <summary>
            /// The code of the message template.
            /// 
            /// You can log on to the [Short Message Service (SMS) console](https://dysms.console.aliyun.com/dysms.htm), click **Go China** or **Go Globe** in the left-side navigation pane, and then view the template code on the **Templates** tab. You can also call the [AddSmsTemplate](https://help.aliyun.com/document_detail/121208.html) operation to obtain the template code.
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// The content of the message template.
            /// </summary>
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            /// <summary>
            /// The name of the message template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// The type of the message template. Valid values:
            /// 
            /// *   **0**: notification message
            /// *   **1**: promotional message
            /// *   **2**: verification code
            /// *   **6**: message sent to countries or regions outside the Chinese mainland
            /// *   **7**: digital message
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public int? TemplateType { get; set; }

        }

        /// <summary>
        /// The total number of templates.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
