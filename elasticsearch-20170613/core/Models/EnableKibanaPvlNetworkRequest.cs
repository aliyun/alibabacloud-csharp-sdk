// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class EnableKibanaPvlNetworkRequest : TeaModel {
        [NameInMap("endpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        [NameInMap("securityGroups")]
        [Validation(Required=false)]
        public List<string> SecurityGroups { get; set; }

        [NameInMap("vSwitchIdsZone")]
        [Validation(Required=false)]
        public List<EnableKibanaPvlNetworkRequestVSwitchIdsZone> VSwitchIdsZone { get; set; }
        public class EnableKibanaPvlNetworkRequestVSwitchIdsZone : TeaModel {
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
