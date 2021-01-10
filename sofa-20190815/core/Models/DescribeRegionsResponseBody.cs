// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyData> Data { get; set; }
        public class DescribeRegionsResponseBodyData : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("RegionIaasId")]
            [Validation(Required=false)]
            public string RegionIaasId { get; set; }

            [NameInMap("AvailableNetworkTypes")]
            [Validation(Required=false)]
            public List<string> AvailableNetworkTypes { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("PaasId")]
            [Validation(Required=false)]
            public string PaasId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ZoneIds")]
            [Validation(Required=false)]
            public List<string> ZoneIds { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
