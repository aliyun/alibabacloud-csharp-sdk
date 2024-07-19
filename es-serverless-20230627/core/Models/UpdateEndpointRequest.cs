// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateEndpointRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("endpointZones")]
        [Validation(Required=false)]
        public List<UpdateEndpointRequestEndpointZones> EndpointZones { get; set; }
        public class UpdateEndpointRequestEndpointZones : TeaModel {
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
