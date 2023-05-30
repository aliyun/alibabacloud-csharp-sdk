// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListProvisionConfigsResponseBody : TeaModel {
        /// <summary>
        /// The qualifier of the service to which resources belong. The qualifier must be aliasName and used together with the serviceName parameter.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The time when Function Compute API is called. Specify the time in the **EEE,d MMM yyyy HH:mm:ss GMT** format.
        /// </summary>
        [NameInMap("provisionConfigs")]
        [Validation(Required=false)]
        public List<ListProvisionConfigsResponseBodyProvisionConfigs> ProvisionConfigs { get; set; }
        public class ListProvisionConfigsResponseBodyProvisionConfigs : TeaModel {
            [NameInMap("alwaysAllocateCPU")]
            [Validation(Required=false)]
            public bool? AlwaysAllocateCPU { get; set; }

            /// <summary>
            /// The expected number of provisioned instances.
            /// </summary>
            [NameInMap("current")]
            [Validation(Required=false)]
            public long? Current { get; set; }

            /// <summary>
            /// 139490
            /// </summary>
            [NameInMap("currentError")]
            [Validation(Required=false)]
            public string CurrentError { get; set; }

            /// <summary>
            /// Details about the scheduled scaling policy. You can use the scheduled scaling policy to flexibly configure provisioned instances. You can specify the number of provisioned instances to the desired value at the scheduled time. This way, the number of provisioned instances can meet the concurrency requirements of your business.
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// The ID of your Alibaba Cloud account.
            /// </summary>
            [NameInMap("scheduledActions")]
            [Validation(Required=false)]
            public List<ScheduledActions> ScheduledActions { get; set; }

            /// <summary>
            /// The configuration of metric-based auto scaling. Provisioned instances are scaled in or out every minute based on the concurrency utilization of provisioned instances. 
            /// 
            /// - If the metric value exceeds the value of the metricTarget parameter, the system scales out provisioned instances based on a progressive policy to make the metric value closer to the value of the metricTarget parameter. 
            /// - When the metric value is smaller than the value of the metricTarget parameter, the system scales in provisioned instances based on a conservative policy to make the metric value close to the value of the metricTarget parameter. 
            /// 
            /// After you specify the maximum and minimum numbers of provisioned instances, the system scales in or out provisioned instances within the range from the minimum number to the maximum number. If the number of provisioned instances is beyond the range, the scaling stops.
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public long? Target { get; set; }

            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("targetTrackingPolicies")]
            [Validation(Required=false)]
            public List<TargetTrackingPolicies> TargetTrackingPolicies { get; set; }

        }

    }

}
