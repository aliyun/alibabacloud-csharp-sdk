// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertContactGroupResponseBody : TeaModel {
        /// <summary>
        /// The information about the alert contact groups.
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public List<SearchAlertContactGroupResponseBodyContactGroups> ContactGroups { get; set; }
        public class SearchAlertContactGroupResponseBodyContactGroups : TeaModel {
            /// <summary>
            /// The ID of the alert contact group.
            /// </summary>
            [NameInMap("ContactGroupId")]
            [Validation(Required=false)]
            public long? ContactGroupId { get; set; }

            /// <summary>
            /// The name of the alert contact group.
            /// </summary>
            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// The alert contact list.
            /// </summary>
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<SearchAlertContactGroupResponseBodyContactGroupsContacts> Contacts { get; set; }
            public class SearchAlertContactGroupResponseBodyContactGroupsContacts : TeaModel {
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
                /// The time when the alert contact group list was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
                /// Indicates whether the alert contact receives system notifications. Valid values:
                /// 
                /// *   true: receives system notifications.
                /// *   false: does not receive system notifications.
                /// </summary>
                [NameInMap("SystemNoc")]
                [Validation(Required=false)]
                public bool? SystemNoc { get; set; }

                /// <summary>
                /// The time when the alert contact group was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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

            }

            /// <summary>
            /// The time when the alert contact group list was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The time when the alert contact group was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
