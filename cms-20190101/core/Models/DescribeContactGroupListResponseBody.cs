// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactGroupListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about alert groups that were queried.
        /// </summary>
        [NameInMap("ContactGroupList")]
        [Validation(Required=false)]
        public DescribeContactGroupListResponseBodyContactGroupList ContactGroupList { get; set; }
        public class DescribeContactGroupListResponseBodyContactGroupList : TeaModel {
            [NameInMap("ContactGroup")]
            [Validation(Required=false)]
            public List<DescribeContactGroupListResponseBodyContactGroupListContactGroup> ContactGroup { get; set; }
            public class DescribeContactGroupListResponseBodyContactGroupListContactGroup : TeaModel {
                /// <summary>
                /// The alert contacts in the alert group.
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts Contacts { get; set; }
                public class DescribeContactGroupListResponseBodyContactGroupListContactGroupContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<string> Contact { get; set; }

                }

                /// <summary>
                /// The time when the alert group was created. This value is a UNIX timestamp that represents the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The description of the alert group.
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// Indicates whether the alert group subscribes to weekly reports. Valid values:
                /// 
                /// *   true: The alert group subscribes to weekly reports.
                /// *   false: The alert group does not subscribe to weekly reports.
                /// </summary>
                [NameInMap("EnableSubscribed")]
                [Validation(Required=false)]
                public bool? EnableSubscribed { get; set; }

                /// <summary>
                /// Indicates whether the alert group can subscribe to weekly reports. Valid values:
                /// 
                /// *   true: The alert group can subscribe to weekly reports.
                /// *   false: The alert group cannot subscribe to weekly reports.
                /// 
                /// >  The weekly report subscription feature is only available for Alibaba Cloud accounts with more than five Elastic Compute Service (ECS) instances.
                /// </summary>
                [NameInMap("EnabledWeeklyReport")]
                [Validation(Required=false)]
                public bool? EnabledWeeklyReport { get; set; }

                /// <summary>
                /// The name of the alert group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The time when the alert group was modified. This value is a UNIX timestamp that represents the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The names of alert groups.
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public DescribeContactGroupListResponseBodyContactGroups ContactGroups { get; set; }
        public class DescribeContactGroupListResponseBodyContactGroups : TeaModel {
            [NameInMap("ContactGroup")]
            [Validation(Required=false)]
            public List<string> ContactGroup { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of the returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
