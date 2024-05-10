// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVSwitchCidrReservationsRequest : TeaModel {
        /// <summary>
        /// The IP version of the reserved CIDR block. Valid values:
        /// 
        /// *   **IPv4** (default)
        /// *   **IPv6**
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **10**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of NextToken.
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
        /// The region ID of the vSwitch.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListVSwitchCidrReservationsRequestTags> Tags { get; set; }
        public class ListVSwitchCidrReservationsRequestTags : TeaModel {
            /// <summary>
            /// The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// A tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length, and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the reserved CIDR block. You can specify at most 10 IDs.
        /// </summary>
        [NameInMap("VSwitchCidrReservationIds")]
        [Validation(Required=false)]
        public List<string> VSwitchCidrReservationIds { get; set; }

        /// <summary>
        /// The type of the reserved CIDR block. Set the value to **prefix**.
        /// 
        /// >  When you allocate CIDR blocks, or enable the service to automatically allocate CIDR blocks to elastic network interfaces (ENIs), the CIDR blocks to allocate must fall into the reserved CIDR block. If the reserved CIDR is exhausted, an error message is returned.
        /// </summary>
        [NameInMap("VSwitchCidrReservationType")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationType { get; set; }

        /// <summary>
        /// The ID of the vSwitch for which you want to query reserved CIDR blocks.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
