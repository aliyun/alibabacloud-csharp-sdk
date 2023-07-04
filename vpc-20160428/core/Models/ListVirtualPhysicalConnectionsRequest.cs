// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsRequest : TeaModel {
        /// <summary>
        /// Specifies whether the hosted connection is accepted by the tenant. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If this is your first query or no subsequent query is to be sent, ignore this parameter.
        /// *   If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the Express Connect circuit over which the hosted connection is created.
        /// 
        /// Express Connect circuits in this topic refer to Express Connect circuits over which hosted connections are created.
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// The region ID of the hosted connection.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsRequestTags> Tags { get; set; }
        public class ListVirtualPhysicalConnectionsRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the resource. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The key cannot exceed 64 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the resource. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The value cannot exceed 128 characters in length and can contain digits, periods (.), underscores (\_), and hyphens (-). The value must start with a letter but cannot start with `aliyun` or `acs:`. The value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VirtualPhysicalConnectionAliUids")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionAliUids { get; set; }

        /// <summary>
        /// The business status of the hosted connection. Valid values:
        /// 
        /// *   **Normal**: normal
        /// *   **FinancialLocked**: locked due to overdue payments
        /// *   **SecurityLocked**: locked for security reasons
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionBusinessStatus")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnectionBusinessStatus { get; set; }

        [NameInMap("VirtualPhysicalConnectionIds")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionIds { get; set; }

        [NameInMap("VirtualPhysicalConnectionStatuses")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionStatuses { get; set; }

        [NameInMap("VlanIds")]
        [Validation(Required=false)]
        public List<string> VlanIds { get; set; }

    }

}
