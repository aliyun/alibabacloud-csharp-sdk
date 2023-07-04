// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DisableNatGatewayEcsMetricRequest : TeaModel {
        /// <summary>
        /// Specifies whether to precheck this request only. Valid values:
        /// 
        /// **true**: The validity of the request is checked but ECS traffic monitoring is not disabled. Check items include whether your AccessKey pair is valid, whether Resource Access Management (RAM) users are authorized, and whether the required parameters are set. If the request fails the precheck, the corresponding error code is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// 
        /// **false** (default): The validity of the request is checked. If the request passes the precheck, a 2XX HTTP status code is returned and ECS traffic monitoring is disabled.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the NAT gateway for which you want to disable Elastic Compute Service (ECS) traffic monitoring.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The ID of the region where the NAT gateway is deployed. You can call the [DescribeRegions](~~36063~~) operation to query region IDs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
