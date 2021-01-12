// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDTCSecurityIpHostsForSQLServerResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("IpHostPairNum")]
        [Validation(Required=false)]
        public string IpHostPairNum { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDTCSecurityIpHostsForSQLServerResponseBodyItems Items { get; set; }
        public class DescribeDTCSecurityIpHostsForSQLServerResponseBodyItems : TeaModel {
            [NameInMap("WhiteListGroups")]
            [Validation(Required=false)]
            public List<DescribeDTCSecurityIpHostsForSQLServerResponseBodyItemsWhiteListGroups> WhiteListGroups { get; set; }
            public class DescribeDTCSecurityIpHostsForSQLServerResponseBodyItemsWhiteListGroups : TeaModel {
                public string SecurityIpHosts { get; set; }
                public string WhitelistGroupName { get; set; }
            }
        };

    }

}
