// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Geoip20200101.Models
{
    public class DescribeGeoipInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GeoipInstances")]
        [Validation(Required=false)]
        public DescribeGeoipInstancesResponseBodyGeoipInstances GeoipInstances { get; set; }
        public class DescribeGeoipInstancesResponseBodyGeoipInstances : TeaModel {
            [NameInMap("GeoipInstance")]
            [Validation(Required=false)]
            public List<DescribeGeoipInstancesResponseBodyGeoipInstancesGeoipInstance> GeoipInstance { get; set; }
            public class DescribeGeoipInstancesResponseBodyGeoipInstancesGeoipInstance : TeaModel {
                public string Status { get; set; }
                public long? ExpireTimestamp { get; set; }
                public string ExpireTime { get; set; }
                public long? MaxQps { get; set; }
                public string CreateTime { get; set; }
                public long? MaxQpd { get; set; }
                public string InstanceId { get; set; }
                public string VersionCode { get; set; }
                public long? CreateTimestamp { get; set; }
                public string ProductCode { get; set; }
            }
        };

    }

}
