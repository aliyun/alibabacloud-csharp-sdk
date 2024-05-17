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
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
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
            /// The CEN instance ID.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The region ID of the transit router.
            /// 
            /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query the most recent region list.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the multicast domain.
            /// 
            /// The valid value is **Active**, which indicates that the multicast domain is available.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags> Tags { get; set; }
            public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The transit router ID.
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
