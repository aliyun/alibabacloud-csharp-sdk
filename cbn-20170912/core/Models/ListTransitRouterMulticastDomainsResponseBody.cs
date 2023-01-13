// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastDomainsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If **NextToken** is empty, it indicates that no next query is to be sent.
        /// *   If **NextToken** is not empty, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the multicast domain.
        /// </summary>
        [NameInMap("TransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains> TransitRouterMulticastDomains { get; set; }
        public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains : TeaModel {
            /// <summary>
            /// The status of the multicast domain.
            /// 
            /// Valid value: **Active**, which indicates that the multicast domain is available.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the multicast domain.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags> Tags { get; set; }
            public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags : TeaModel {
                /// <summary>
                /// The tag key of the multicast domain.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the multicast domain.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// The description of the multicast domain.
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainDescription")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainDescription { get; set; }

            /// <summary>
            /// The ID of the multicast domain.
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// The name of the multicast domain.
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainName")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainName { get; set; }

        }

    }

}
