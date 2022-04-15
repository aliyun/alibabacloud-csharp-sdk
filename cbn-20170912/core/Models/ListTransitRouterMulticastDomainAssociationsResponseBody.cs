// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastDomainAssociationsResponseBody : TeaModel {
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

        [NameInMap("TransitRouterMulticastAssociations")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastDomainAssociationsResponseBodyTransitRouterMulticastAssociations> TransitRouterMulticastAssociations { get; set; }
        public class ListTransitRouterMulticastDomainAssociationsResponseBodyTransitRouterMulticastAssociations : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

    }

}
