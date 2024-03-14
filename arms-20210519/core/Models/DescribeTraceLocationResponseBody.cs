// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class DescribeTraceLocationResponseBody : TeaModel {
        [NameInMap("RegionConfigs")]
        [Validation(Required=false)]
        public List<DescribeTraceLocationResponseBodyRegionConfigs> RegionConfigs { get; set; }
        public class DescribeTraceLocationResponseBodyRegionConfigs : TeaModel {
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
