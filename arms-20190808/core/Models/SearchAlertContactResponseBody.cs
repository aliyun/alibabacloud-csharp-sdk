// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertContactResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertContactResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertContactResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The information about the alert contacts.
            /// </summary>
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<SearchAlertContactResponseBodyPageBeanContacts> Contacts { get; set; }
            public class SearchAlertContactResponseBodyPageBeanContacts : TeaModel {
                /// <summary>
                /// The ID of the alert contact.
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public long? ContactId { get; set; }

                /// <summary>
                /// The name of the alert contact.
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// The contact group to which the contact belongs. If your contacts are added to multiple contact groups, the contact groups are separated by vertical bars (|).
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The timestamp generated when the alert contact was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The webhook URL of the DingTalk chatbot.
                /// </summary>
                [NameInMap("DingRobot")]
                [Validation(Required=false)]
                public string DingRobot { get; set; }

                /// <summary>
                /// The email address of the alert contact.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The mobile number of the alert contact.
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the alert contact receives system notifications. Valid values:
                /// 
                /// *   `true`: The alert contact receives system notifications.
                /// *   `false`: The alert contact does not receive system notifications.
                /// </summary>
                [NameInMap("SystemNoc")]
                [Validation(Required=false)]
                public bool? SystemNoc { get; set; }

                /// <summary>
                /// The timestamp generated when the alert contact was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The information about the webhook.
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

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
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
