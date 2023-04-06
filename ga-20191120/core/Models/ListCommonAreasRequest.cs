// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCommonAreasRequest : TeaModel {
        /// <summary>
        /// The IP version used to connect to the GA instance. Valid values:
        /// 
        /// *   **IPv4** (default): queries regions that support IPv4.
        /// *   **IPv6** :queries regions that support IPv6.
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// Specifies whether to query regions where endpoint groups can be deployed.
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("IsEpg")]
        [Validation(Required=false)]
        public bool? IsEpg { get; set; }

        /// <summary>
        /// Specifies whether to query regions supported by GA.
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("IsIpSet")]
        [Validation(Required=false)]
        public bool? IsIpSet { get; set; }

    }

}
