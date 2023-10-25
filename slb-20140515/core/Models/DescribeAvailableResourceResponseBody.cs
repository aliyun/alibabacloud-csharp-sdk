// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// The zones and the supported resources.
        /// </summary>
        [NameInMap("AvailableResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableResources AvailableResources { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableResources : TeaModel {
            [NameInMap("AvailableResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResource> AvailableResource { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResource : TeaModel {
                /// <summary>
                /// The primary zone.
                /// </summary>
                [NameInMap("MasterZoneId")]
                [Validation(Required=false)]
                public string MasterZoneId { get; set; }

                /// <summary>
                /// The secondary zone.
                /// </summary>
                [NameInMap("SlaveZoneId")]
                [Validation(Required=false)]
                public string SlaveZoneId { get; set; }

                /// <summary>
                /// The supported resources.
                /// </summary>
                [NameInMap("SupportResources")]
                [Validation(Required=false)]
                public DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResources SupportResources { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResources : TeaModel {
                    [NameInMap("SupportResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResourcesSupportResource> SupportResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableResourcesAvailableResourceSupportResourcesSupportResource : TeaModel {
                        /// <summary>
                        /// The type of the IP address.
                        /// 
                        /// Valid values: **ipv4 and ipv6**.
                        /// </summary>
                        [NameInMap("AddressIPVersion")]
                        [Validation(Required=false)]
                        public string AddressIPVersion { get; set; }

                        /// <summary>
                        /// The network type.
                        /// 
                        /// Valid values: **vpc, classic-internet, and classic-intranet**.
                        /// </summary>
                        [NameInMap("AddressType")]
                        [Validation(Required=false)]
                        public string AddressType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
