// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListKibanaPvlNetworkResponseBody : TeaModel {
        /// <summary>
        /// request id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListKibanaPvlNetworkResponseBodyResult> Result { get; set; }
        public class ListKibanaPvlNetworkResponseBodyResult : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            [NameInMap("endpointStatus")]
            [Validation(Required=false)]
            public string EndpointStatus { get; set; }

            [NameInMap("pvlId")]
            [Validation(Required=false)]
            public string PvlId { get; set; }

            [NameInMap("securityGroups")]
            [Validation(Required=false)]
            public List<string> SecurityGroups { get; set; }

            [NameInMap("vSwitchIdsZone")]
            [Validation(Required=false)]
            public List<ListKibanaPvlNetworkResponseBodyResultVSwitchIdsZone> VSwitchIdsZone { get; set; }
            public class ListKibanaPvlNetworkResponseBodyResultVSwitchIdsZone : TeaModel {
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

}
