// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ConfigADConnectorTrustRequest : TeaModel {
        /// <summary>
        /// The ID of the enterprise AD office network.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// Specifies whether to configure a trust password for the Remote Desktop Services (RDS) License Domain of the enterprise AD office network.
        /// 
        /// Valid values:
        /// 
        /// *   true: configures a trust password for the RDS License Domain of the AD office network.
        /// 
        /// *   false: configures a trust password for a regular enterprise AD office network.
        /// </summary>
        [NameInMap("RdsLicenseDomain")]
        [Validation(Required=false)]
        public bool? RdsLicenseDomain { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The trust password. You can specify the password when you configure a trust relationship between the AD domain and the ecd.acs domain.
        /// </summary>
        [NameInMap("TrustKey")]
        [Validation(Required=false)]
        public string TrustKey { get; set; }

    }

}
