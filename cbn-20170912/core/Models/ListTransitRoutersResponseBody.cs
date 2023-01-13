// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRoutersResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// A list of transit routers.
        /// </summary>
        [NameInMap("TransitRouters")]
        [Validation(Required=false)]
        public List<ListTransitRoutersResponseBodyTransitRouters> TransitRouters { get; set; }
        public class ListTransitRoutersResponseBodyTransitRouters : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the CEN instance belongs.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The ID of the CEN instance.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The time when the transit router was created.
            /// 
            /// The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the region where the transit router is deployed.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the transit router. Valid values:
            /// 
            /// *   **Creating**: The transit router is being created.
            /// *   **Active**: The transit router is available.
            /// *   **Modifying**: The transit router is being modified
            /// *   **Deleting**: The transit router is being deleted.
            /// *   **Upgrading**: The transit router is being upgraded.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// Indicates whether multicast is enabled for the transit router. Valid values:
            /// 
            /// *   **true**: enabled
            /// *   **false**: disabled
            /// </summary>
            [NameInMap("SupportMulticast")]
            [Validation(Required=false)]
            public bool? SupportMulticast { get; set; }

            /// <summary>
            /// A list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRoutersResponseBodyTransitRoutersTags> Tags { get; set; }
            public class ListTransitRoutersResponseBodyTransitRoutersTags : TeaModel {
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
            /// The information about the CIDR block of the transit router.
            /// </summary>
            [NameInMap("TransitRouterCidrList")]
            [Validation(Required=false)]
            public List<ListTransitRoutersResponseBodyTransitRoutersTransitRouterCidrList> TransitRouterCidrList { get; set; }
            public class ListTransitRoutersResponseBodyTransitRoutersTransitRouterCidrList : TeaModel {
                /// <summary>
                /// The CIDR block of the transit router.
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// The description of the CIDR block.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the CIDR block.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether to allow the system to automatically add the CIDR block to the route table of the transit router.  
                /// 
                /// - **true**: yes  
                /// 
                /// A value of **true** indicates that after you create a private VPN connection and enable route learning for the VPN connection, the system automatically adds a blackhole route to the route table of the transit router to which the VPN connection is attached. 
                /// 
                /// The destination CIDR block of the blackhole route is the CIDR block of the transit router. The CIDR block of the transit router refers to the CIDR block from which gateway IP addresses are allocated to IPsec-VPN connections.  
                /// 
                /// The blackhole route is advertised only to the route table of the virtual border router (VBR) that is connected to the transit router.
                /// - **false**: no
                /// </summary>
                [NameInMap("PublishCidrRoute")]
                [Validation(Required=false)]
                public bool? PublishCidrRoute { get; set; }

                /// <summary>
                /// The ID of the CIDR block.
                /// </summary>
                [NameInMap("TransitRouterCidrId")]
                [Validation(Required=false)]
                public string TransitRouterCidrId { get; set; }

            }

            /// <summary>
            /// The description of the transit router.
            /// </summary>
            [NameInMap("TransitRouterDescription")]
            [Validation(Required=false)]
            public string TransitRouterDescription { get; set; }

            /// <summary>
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// The name of the transit router.
            /// </summary>
            [NameInMap("TransitRouterName")]
            [Validation(Required=false)]
            public string TransitRouterName { get; set; }

            /// <summary>
            /// The edition of the transit router. Valid values:
            /// 
            /// *   **Enterprise**: Enhance Edition
            /// *   **Basic**: Basic Edition
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
