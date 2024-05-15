// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// The attribute of the ENI. Valid values:
        /// 
        /// attachment: attachment information about the ENI 
        /// 
        /// >This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("Attribute")]
        [Validation(Required=false)]
        public string Attribute { get; set; }

        /// <summary>
        /// The ID of the ENI.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the ENI. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
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
        /// >  This parameter is unavailable.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeNetworkInterfaceAttributeRequestTag> Tag { get; set; }
        public class DescribeNetworkInterfaceAttributeRequestTag : TeaModel {
            /// <summary>
            /// >  This parameter is unavailable.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// >  This parameter is unavailable.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
