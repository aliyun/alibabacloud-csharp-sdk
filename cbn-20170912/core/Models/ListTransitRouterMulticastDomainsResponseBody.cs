// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastDomainsResponseBody : TeaModel {
        /// <summary>
        /// $.parameters[8].schema.example
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// $.parameters[8].schema.enumValueTitles
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// $.parameters[7].schema.enumValueTitles
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// $.parameters[8].schema.description
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// {
        ///     "RequestId": "8A0F93D1-FD6C-56FC-B6D2-668FC92D12D2",
        ///     "TotalCount": 1,
        ///     "MaxResults": 20,
        ///     "NextToken": "FFmyTO70tTpLG6I3FmYAXGKPd****",
        ///     "TransitRouterMulticastDomains": [
        ///         {
        ///             "TransitRouterMulticastDomainId": "tr-mcast-domain-3r3bvbypxqheej****",
        ///             "TransitRouterMulticastDomainName": "nametest",
        ///             "TransitRouterMulticastDomainDescription": "desctest",
        ///             "Status": "Active"
        ///         }
        ///     ]
        /// }
        /// </summary>
        [NameInMap("TransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains> TransitRouterMulticastDomains { get; set; }
        public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains : TeaModel {
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// WB656982
            /// </summary>
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

            /// <summary>
            /// ListTransitRouterMulticastDomains
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainDescription")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainDescription { get; set; }

            /// <summary>
            /// <ListTransitRouterMulticastDomainsResponse>
            ///     <RequestId>8A0F93D1-FD6C-56FC-B6D2-668FC92D12D2</RequestId>
            ///     <TotalCount>1</TotalCount>
            ///     <MaxResults>20</MaxResults>
            ///     <NextToken>FFmyTO70tTpLG6I3FmYAXGKPd****</NextToken>
            ///     <TransitRouterMulticastDomains>
            ///         <TransitRouterMulticastDomainId>tr-mcast-domain-3r3bvbypxqheej****</TransitRouterMulticastDomainId>
            ///         <TransitRouterMulticastDomainName>nametest</TransitRouterMulticastDomainName>
            ///         <TransitRouterMulticastDomainDescription>desctest</TransitRouterMulticastDomainDescription>
            ///         <Status>Active</Status>
            ///     </TransitRouterMulticastDomains>
            /// </ListTransitRouterMulticastDomainsResponse>
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// Queries the information about a multicast domain.
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainName")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainName { get; set; }

        }

    }

}
