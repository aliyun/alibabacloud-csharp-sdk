// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Geoip20200101.Models
{
    public class DescribeGeoipInstanceDataInfosResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DataInfos")]
        [Validation(Required=false)]
        public DescribeGeoipInstanceDataInfosResponseBodyDataInfos DataInfos { get; set; }
        public class DescribeGeoipInstanceDataInfosResponseBodyDataInfos : TeaModel {
            [NameInMap("DataInfo")]
            [Validation(Required=false)]
            public List<DescribeGeoipInstanceDataInfosResponseBodyDataInfosDataInfo> DataInfo { get; set; }
            public class DescribeGeoipInstanceDataInfosResponseBodyDataInfosDataInfo : TeaModel {
                public string Type { get; set; }
                public long? UpdateTimestamp { get; set; }
                public string UpdateTime { get; set; }
                public string Version { get; set; }
                public long? DownloadCount { get; set; }
            }
        };

    }

}
