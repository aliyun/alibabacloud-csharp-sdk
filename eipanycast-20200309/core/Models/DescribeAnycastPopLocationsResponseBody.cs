// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastPopLocationsResponseBody : TeaModel {
        [NameInMap("AnycastPopLocationList")]
        [Validation(Required=false)]
        public List<DescribeAnycastPopLocationsResponseBodyAnycastPopLocationList> AnycastPopLocationList { get; set; }
        public class DescribeAnycastPopLocationsResponseBodyAnycastPopLocationList : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
