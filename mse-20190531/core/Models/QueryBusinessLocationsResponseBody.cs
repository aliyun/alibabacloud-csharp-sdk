// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryBusinessLocationsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryBusinessLocationsResponseBodyData> Data { get; set; }
        public class QueryBusinessLocationsResponseBodyData : TeaModel {
            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DistrictCnName")]
            [Validation(Required=false)]
            public string DistrictCnName { get; set; }

            [NameInMap("DistrictEnName")]
            [Validation(Required=false)]
            public string DistrictEnName { get; set; }

            [NameInMap("DistrictId")]
            [Validation(Required=false)]
            public string DistrictId { get; set; }

            [NameInMap("DistrictOrdering")]
            [Validation(Required=false)]
            public int? DistrictOrdering { get; set; }

            [NameInMap("DistrictShowName")]
            [Validation(Required=false)]
            public string DistrictShowName { get; set; }

            [NameInMap("EnDescription")]
            [Validation(Required=false)]
            public string EnDescription { get; set; }

            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Ordering")]
            [Validation(Required=false)]
            public int? Ordering { get; set; }

            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
