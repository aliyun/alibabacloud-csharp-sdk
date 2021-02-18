// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Geoip20200101.Models
{
    public class DescribeGeoipInstanceResponseBody : TeaModel {
        [NameInMap("ExpireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        [NameInMap("MaxQpd")]
        [Validation(Required=false)]
        public long? MaxQpd { get; set; }

        [NameInMap("MaxQps")]
        [Validation(Required=false)]
        public long? MaxQps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("QueryCount")]
        [Validation(Required=false)]
        public long? QueryCount { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

    }

}
