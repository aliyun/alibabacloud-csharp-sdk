// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupNotifyPolicyListResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned policies.
        /// </summary>
        [NameInMap("NotifyPolicyList")]
        [Validation(Required=false)]
        public DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyList NotifyPolicyList { get; set; }
        public class DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyList : TeaModel {
            [NameInMap("NotifyPolicy")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyListNotifyPolicy> NotifyPolicy { get; set; }
            public class DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyListNotifyPolicy : TeaModel {
                /// <summary>
                /// The end of the time range to query.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The policy ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The beginning of the time range to query.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The policy type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
