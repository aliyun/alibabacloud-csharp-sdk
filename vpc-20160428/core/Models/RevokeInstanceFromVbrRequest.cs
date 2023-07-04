// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class RevokeInstanceFromVbrRequest : TeaModel {
        /// <summary>
        /// The VBRs for which you want to revoke permissions on the VPC. Valid values:
        /// 
        /// *   **ALL**: Permissions on the VPC are revoked for all VBRs in the specified region. **VbrInstanceIds** can be left empty.
        /// *   **Specify**: Permissions on the VPC are revoked for the specified VBRs. **VbrInstanceIds** must be assigned a value.
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// The VPC ID.
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
        /// The IDs of the VBRs for which you want to revoke the permissions.
        /// </summary>
        [NameInMap("VbrInstanceIds")]
        [Validation(Required=false)]
        public List<string> VbrInstanceIds { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the VBR belongs.
        /// </summary>
        [NameInMap("VbrOwnerUid")]
        [Validation(Required=false)]
        public string VbrOwnerUid { get; set; }

        /// <summary>
        /// The ID of the region where the VBR is deployed.
        /// </summary>
        [NameInMap("VbrRegionNo")]
        [Validation(Required=false)]
        public string VbrRegionNo { get; set; }

    }

}
