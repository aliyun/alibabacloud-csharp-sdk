// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDTCSecurityIpHostsForSQLServerResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The number of distributed transaction whitelists.
        /// </summary>
        [NameInMap("IpHostPairNum")]
        [Validation(Required=false)]
        public string IpHostPairNum { get; set; }

        /// <summary>
        /// Details of distributed transaction whitelists.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDTCSecurityIpHostsForSQLServerResponseBodyItems Items { get; set; }
        public class DescribeDTCSecurityIpHostsForSQLServerResponseBodyItems : TeaModel {
            [NameInMap("WhiteListGroups")]
            [Validation(Required=false)]
            public List<DescribeDTCSecurityIpHostsForSQLServerResponseBodyItemsWhiteListGroups> WhiteListGroups { get; set; }
            public class DescribeDTCSecurityIpHostsForSQLServerResponseBodyItemsWhiteListGroups : TeaModel {
                /// <summary>
                /// The IP address of the ECS instance and the hostname of the Windows computer. Format: `IP address,Hostname`. Multiple values are separated with semicolons (;).
                /// </summary>
                [NameInMap("SecurityIpHosts")]
                [Validation(Required=false)]
                public string SecurityIpHosts { get; set; }

                /// <summary>
                /// The name of the distributed transaction whitelist.
                /// </summary>
                [NameInMap("WhitelistGroupName")]
                [Validation(Required=false)]
                public string WhitelistGroupName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
