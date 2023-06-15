// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class QueryNotifyResponseBody : TeaModel {
        /// <summary>
        /// The details of the returned parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryNotifyResponseBodyData Data { get; set; }
        public class QueryNotifyResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the notification.
            /// </summary>
            [NameInMap("NotifyItemList")]
            [Validation(Required=false)]
            public List<QueryNotifyResponseBodyDataNotifyItemList> NotifyItemList { get; set; }
            public class QueryNotifyResponseBodyDataNotifyItemList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// Indicates whether the notification has been confirmed. You can call the ConfirmNotify operation to mark the notification as confirmed. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("ConfirmFlag")]
                [Validation(Required=false)]
                public bool? ConfirmFlag { get; set; }

                /// <summary>
                /// The UID of the contact who called the ConfirmNotify operation to mark the notification as confirmed. The contact belongs to the current Alibaba Cloud account.
                /// 
                /// The value **0** indicates that the notification is automatically confirmed by the system.
                /// </summary>
                [NameInMap("Confirmor")]
                [Validation(Required=false)]
                public long? Confirmor { get; set; }

                /// <summary>
                /// The time when the notification was created.
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// The time when the notification was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the notification.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The number of times that repeatedly sent notifications are blocked.
                /// </summary>
                [NameInMap("IdempotentCount")]
                [Validation(Required=false)]
                public string IdempotentCount { get; set; }

                /// <summary>
                /// This parameter ensures the idempotence of the notification and prevents the notification from being repeatedly sent.
                /// </summary>
                [NameInMap("IdempotentId")]
                [Validation(Required=false)]
                public string IdempotentId { get; set; }

                /// <summary>
                /// The level of the notification. Valid values:
                /// 
                /// *   **help**
                /// *   **success**
                /// *   **warning**
                /// *   **error**
                /// *   **loading**
                /// *   **notice**
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The element in the notification template. This parameter is a JSON string. Fields in the JSON string vary based on the value of the **TemplateName** parameter.
                /// 
                /// *   If the **TemplateName** parameter is **RenewalRecommend**, the JSON string contains the following fields:
                /// 
                ///     *   **instanceName**: the ID of the instance that is about to expire
                ///     *   **reservedTime**: the remaining validity period of the instance in days
                /// 
                /// *   If the **TemplateName** parameter is **InstanceCreateFailed**, the JSON string contains the following fields:
                /// 
                ///     *   **orderId**: the ID of the order to purchase the instance
                ///     *   **reason**: the cause of the instance creation failure
                /// </summary>
                [NameInMap("NotifyElement")]
                [Validation(Required=false)]
                public string NotifyElement { get; set; }

                /// <summary>
                /// The template of the notification. Valid values:
                /// 
                /// *   **RenewalRecommend**: The template that is used to notify of renewal suggestions.
                /// *   **InstanceCreateFailed**: The template that is used to notify that an instance fails to be created and is refunded.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// The type of the notification. Valid values:
                /// 
                /// *   **Sell**: sales notification
                /// *   **Operation**: O\&M notification
                /// *   **Promotion**: promotion notification
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries.
            /// </summary>
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
