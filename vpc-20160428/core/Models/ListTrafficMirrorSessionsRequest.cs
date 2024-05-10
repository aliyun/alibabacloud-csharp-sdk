// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorSessionsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the traffic mirror session. Valid values:
        /// 
        /// *   **false**: does not enable the traffic mirror session.
        /// *   **true**: enables the traffic mirror session.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Valid values: **1** to **100**. Default value: **10**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If this is your first query and no next queries are to be sent, ignore this parameter.
        /// *   If a next query is to be sent, set the value to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The priority of the traffic mirror session. Valid values: **1** to **32766**.
        /// 
        /// A smaller value indicates a higher priority. You cannot specify identical priorities for traffic mirror sessions that are created in the same region by using the same account.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The ID of the region to which the traffic mirror session belongs. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list. For more information about regions that support traffic mirroring, see [Overview of traffic mirroring](https://help.aliyun.com/document_detail/207513.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the mirrored traffic belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags of the resource.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorSessionsRequestTags> Tags { get; set; }
        public class ListTrafficMirrorSessionsRequestTags : TeaModel {
            /// <summary>
            /// The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The key cannot exceed 64 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value cannot exceed 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter but cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the traffic mirror filter.
        /// </summary>
        [NameInMap("TrafficMirrorFilterId")]
        [Validation(Required=false)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// The IDs of the traffic mirror session. The maximum value of N is 100, which indicates that you can query up to 100 traffic mirror sessions at a time.
        /// </summary>
        [NameInMap("TrafficMirrorSessionIds")]
        [Validation(Required=false)]
        public List<string> TrafficMirrorSessionIds { get; set; }

        /// <summary>
        /// The name of the traffic mirror session.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TrafficMirrorSessionName")]
        [Validation(Required=false)]
        public string TrafficMirrorSessionName { get; set; }

        /// <summary>
        /// The ID of the traffic mirror source. You can specify only an elastic network interface (ENI) as the mirror source.
        /// </summary>
        [NameInMap("TrafficMirrorSourceId")]
        [Validation(Required=false)]
        public string TrafficMirrorSourceId { get; set; }

        /// <summary>
        /// The ID of the traffic mirror destination. You can specify only an ENI or a Server Load Balancer (SLB) instance as a traffic mirror destination.
        /// </summary>
        [NameInMap("TrafficMirrorTargetId")]
        [Validation(Required=false)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// The VXLAN network identifier (VNI) that is used to distinguish different mirrored traffic. Valid values: **0** to **16777215**. You can use VNIs to identify mirrored traffic from different sessions at the traffic mirror destination. You can specify a custom VNI or use a random VNI that is allocated by the system. If you want the system to randomly allocate a VNI, ignore this parameter.
        /// </summary>
        [NameInMap("VirtualNetworkId")]
        [Validation(Required=false)]
        public int? VirtualNetworkId { get; set; }

    }

}
