// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ConfigADConnectorTrustRequest : TeaModel {
        /// <summary>
        /// The ID of the AD workspace.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("RdsLicenseDomain")]
        [Validation(Required=false)]
        public bool? RdsLicenseDomain { get; set; }

        /// <summary>
        /// The region ID.
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
