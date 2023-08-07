// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateFlowLogRequest : TeaModel {
        /// <summary>
        /// The sampling interval of the flow log. Unit: seconds. Valid values: **1**, **5**, and **10** (default).
        /// </summary>
        [NameInMap("AggregationInterval")]
        [Validation(Required=false)]
        public int? AggregationInterval { get; set; }

        /// <summary>
        /// The description of the flow log.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the flow log.
        /// 
        /// The name must be 1 to 128 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// The name of the Logstore that stores the captured traffic data.
        /// 
        /// *   The name can contain only lowercase letters, digits, hyphens (-), and underscores (\_).
        /// *   The name must start and end with a lowercase letter or a digit.
        /// *   The name must be 3 to 63 characters in length.
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The name of the project that stores the captured traffic data.
        /// 
        /// *   The name can contain only lowercase letters, digits, and hyphens (-).
        /// *   The name must start and end with a lowercase letter or a digit.
        /// *   The name must be 3 to 63 characters in length.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The ID of the region where you want to create the flow log. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the resource whose traffic you want to capture.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resource whose traffic you want to capture. Valid values:
        /// 
        /// *   **NetworkInterface**: elastic network interface (ENI)
        /// *   **VSwitch**: all ENIs in a vSwitch
        /// *   **VPC**: all ENIs in a virtual private cloud (VPC)
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFlowLogRequestTag> Tag { get; set; }
        public class CreateFlowLogRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TrafficPath")]
        [Validation(Required=false)]
        public List<string> TrafficPath { get; set; }

        /// <summary>
        /// The type of traffic that you want to capture. Valid values:
        /// 
        /// *   **All**: all traffic
        /// *   **Allow**: traffic that is allowed
        /// *   **Drop**: traffic that is rejected
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
