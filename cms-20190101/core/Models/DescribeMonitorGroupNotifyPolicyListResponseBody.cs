// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupNotifyPolicyListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The policies that were returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The type of the policy.
        /// 
        /// Valid value: PauseNotify.
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
                /// The ID of the policy.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeMonitorGroupNotifyPolicyList**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The timestamp that specifies the beginning of the time range to query.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
