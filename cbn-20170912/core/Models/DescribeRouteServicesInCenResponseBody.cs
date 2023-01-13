// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteServicesInCenResponseBody : TeaModel {
        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the cloud services.
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
                /// The ID of the region where the cloud service is accessed.
                /// </summary>
                [NameInMap("AccessRegionId")]
                [Validation(Required=false)]
                public string AccessRegionId { get; set; }

                /// <summary>
                /// The ID of the CEN instance.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The service addresses of the cloud service.
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
                /// The description of the cloud service.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The service address of the cloud service.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The ID of the region where the cloud service is deployed.
                /// </summary>
                [NameInMap("HostRegionId")]
                [Validation(Required=false)]
                public string HostRegionId { get; set; }

                /// <summary>
                /// The ID of the VPC that is associated with the cloud service.
                /// </summary>
                [NameInMap("HostVpcId")]
                [Validation(Required=false)]
                public string HostVpcId { get; set; }

                /// <summary>
                /// The status of the cloud service. Valid values:
                /// 
                /// *   **Creating**: The cloud service is being created.
                /// *   **Active**: The cloud service is available.
                /// *   **Deleting**: The cloud service is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
