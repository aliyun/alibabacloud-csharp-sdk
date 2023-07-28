// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeUnhealthyHostAvailabilityResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// The unhealthy instances that are detected by the specified availability monitoring tasks.
        /// </summary>
        [NameInMap("UnhealthyList")]
        [Validation(Required=false)]
        public DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyList UnhealthyList { get; set; }
        public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyList : TeaModel {
            [NameInMap("NodeTaskInstance")]
            [Validation(Required=false)]
            public List<DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstance> NodeTaskInstance { get; set; }
            public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstance : TeaModel {
                /// <summary>
                /// The ID of the availability monitoring task.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The unhealthy instances that are detected by the availability monitoring task.
                /// </summary>
                [NameInMap("InstanceList")]
                [Validation(Required=false)]
                public DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstanceInstanceList InstanceList { get; set; }
                public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstanceInstanceList : TeaModel {
                    [NameInMap("String")]
                    [Validation(Required=false)]
                    public List<string> String { get; set; }

                }

            }

        }

    }

}
