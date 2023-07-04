// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVSwitchesRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which the vSwitch belongs.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether to query the default vSwitch in the specified region. Valid values:
        /// 
        /// *   **true**: queries the default vSwitch in the specified region.
        /// *   **false**: does not query the default vSwitch in the specified region.
        /// 
        /// If you do not specify this parameter, the system queries all vSwitches in the specified region by default.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the resource belongs.
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
        /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// The name of the vSwitch.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the route table.
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("VSwitchOwnerId")]
        [Validation(Required=false)]
        public long? VSwitchOwnerId { get; set; }

        /// <summary>
        /// The region ID of the vSwitch. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// 
        /// >  You must set at least one of the **RegionId** and **VpcId** parameters.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: checks the request without performing the operation. The system checks the required parameters, request syntax, and limits. If the request fails check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed. This is the default value.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
