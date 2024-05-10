// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVSwitchCidrReservationAttributeRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the vSwitch is deployed.
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
        /// The new description of the reserved CIDR block. The default value is empty.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("VSwitchCidrReservationDescription")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationDescription { get; set; }

        /// <summary>
        /// The ID of the reserved CIDR block.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VSwitchCidrReservationId")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationId { get; set; }

        /// <summary>
        /// The new name of the reserved CIDR block.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("VSwitchCidrReservationName")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationName { get; set; }

    }

}
