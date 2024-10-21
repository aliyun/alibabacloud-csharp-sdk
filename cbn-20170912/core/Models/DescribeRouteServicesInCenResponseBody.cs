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

        /// <summary>
        /// <para>The information about the cloud services.</para>
        /// </summary>
        [NameInMap("RouteServiceEntries")]
        [Validation(Required=false)]
        public DescribeRouteServicesInCenResponseBodyRouteServiceEntries RouteServiceEntries { get; set; }
        public class DescribeRouteServicesInCenResponseBodyRouteServiceEntries : TeaModel {
            [NameInMap("RouteServiceEntry")]
            [Validation(Required=false)]
            public List<DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntry> RouteServiceEntry { get; set; }
            public class DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntry : TeaModel {
                /// <summary>
                /// <para>The ID of the region where the cloud service is accessed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("AccessRegionId")]
                [Validation(Required=false)]
                public string AccessRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-pfa6ugf3xl0qsd****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The service addresses of the cloud service.</para>
                /// </summary>
                [NameInMap("Cidrs")]
                [Validation(Required=false)]
                public DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntryCidrs Cidrs { get; set; }
                public class DescribeRouteServicesInCenResponseBodyRouteServiceEntriesRouteServiceEntryCidrs : TeaModel {
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public List<string> Cidr { get; set; }

                }

                /// <summary>
                /// <para>The description of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>descname</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The service address of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.118.28.0/24</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The region ID of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("HostRegionId")]
                [Validation(Required=false)]
                public string HostRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC associated with the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1h8vbrbcgohcju5****</para>
                /// </summary>
                [NameInMap("HostVpcId")]
                [Validation(Required=false)]
                public string HostVpcId { get; set; }

                /// <summary>
                /// <para>The status of the cloud service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Active</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
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
