// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListAPNsResponseBody : TeaModel {
        [NameInMap("APNs")]
        [Validation(Required=false)]
        public List<ListAPNsResponseBodyAPNs> APNs { get; set; }
        public class ListAPNsResponseBodyAPNs : TeaModel {
            [NameInMap("APN")]
            [Validation(Required=false)]
            public string APN { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FeatureList")]
            [Validation(Required=false)]
            public List<string> FeatureList { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ZoneList")]
            [Validation(Required=false)]
            public List<string> ZoneList { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
