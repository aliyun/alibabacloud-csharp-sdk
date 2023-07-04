// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GrantInstanceToVbrShrinkRequest : TeaModel {
        /// <summary>
        /// The VBRs that need to acquire permissions on the VPC. Valid values:
        /// 
        /// *   **All**: Permissions on the VPC are granted to all VBRs that belong to the specified region and Alibaba Cloud account. In this case, you can leave **VbrInstanceIds** empty.
        /// *   **Specify**: Permissions on the VPC are granted to the specified VBRs. **VbrInstanceIds** must be assigned a value.
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the VPC is deployed.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The information about the VBRs.
        /// </summary>
        [NameInMap("VbrInstanceIds")]
        [Validation(Required=false)]
        public string VbrInstanceIdsShrink { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the VBR belongs.
        /// </summary>
        [NameInMap("VbrOwnerUid")]
        [Validation(Required=false)]
        public long? VbrOwnerUid { get; set; }

        /// <summary>
        /// The ID of the region where the VBR is deployed.
        /// </summary>
        [NameInMap("VbrRegionNo")]
        [Validation(Required=false)]
        public string VbrRegionNo { get; set; }

    }

}
