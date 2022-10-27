// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<DescribeZonesResponseBodyZones> Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

    }

}
