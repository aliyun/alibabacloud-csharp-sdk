// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteServicesInCenResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>196C99CA-6997-5951-9721-AE89720DF856</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteServiceEntries")]
        [Validation(Required=false)]
        public DescribeRouteServicesInCenResponseBodyRouteServiceEntries RouteServiceEntries { get; set; }
        public class DescribeRouteServicesInCenResponseBodyRouteServiceEntries : TeaModel {
            [NameInMap("RouteServiceEntry")]
            [Validation(Required=false)]
            public List<DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntry> RouteServiceEntry { get; set; }
            public class DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntry : TeaModel {
                [NameInMap("AccessRegionId")]
                [Validation(Required=false)]
                public string AccessRegionId { get; set; }

                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("Cidrs")]
                [Validation(Required=false)]
                public DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntryCidrs Cidrs { get; set; }
                public class DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntryCidrs : TeaModel {
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public List<string> Cidr { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("HostRegionId")]
                [Validation(Required=false)]
                public string HostRegionId { get; set; }

                [NameInMap("HostVpcId")]
                [Validation(Required=false)]
                public string HostVpcId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
