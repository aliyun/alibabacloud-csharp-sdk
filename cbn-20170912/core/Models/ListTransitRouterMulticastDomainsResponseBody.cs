// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastDomainsResponseBody : TeaModel {
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

        [NameInMap("TransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains> TransitRouterMulticastDomains { get; set; }
        public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags> Tags { get; set; }
            public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            [NameInMap("TransitRouterMulticastDomainDescription")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainDescription { get; set; }

            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            [NameInMap("TransitRouterMulticastDomainName")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainName { get; set; }

        }

    }

}
