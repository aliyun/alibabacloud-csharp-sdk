// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrAllocationResponseBody : TeaModel {
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

        [NameInMap("TransitRouterCidrAllocations")]
        [Validation(Required=false)]
        public List<ListTransitRouterCidrAllocationResponseBodyTransitRouterCidrAllocations> TransitRouterCidrAllocations { get; set; }
        public class ListTransitRouterCidrAllocationResponseBodyTransitRouterCidrAllocations : TeaModel {
            [NameInMap("AllocatedCidrBlock")]
            [Validation(Required=false)]
            public string AllocatedCidrBlock { get; set; }

            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            [NameInMap("TransitRouterCidrId")]
            [Validation(Required=false)]
            public string TransitRouterCidrId { get; set; }

        }

    }

}
