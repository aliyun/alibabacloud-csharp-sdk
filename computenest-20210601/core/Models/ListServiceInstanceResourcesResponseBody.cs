// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceResourcesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesResponseBodyResources> Resources { get; set; }
        public class ListServiceInstanceResourcesResponseBodyResources : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("RenewStatus")]
            [Validation(Required=false)]
            public string RenewStatus { get; set; }

            [NameInMap("RenewalPeriod")]
            [Validation(Required=false)]
            public int? RenewalPeriod { get; set; }

            [NameInMap("RenewalPeriodUnit")]
            [Validation(Required=false)]
            public string RenewalPeriodUnit { get; set; }

            [NameInMap("ResourceARN")]
            [Validation(Required=false)]
            public string ResourceARN { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
