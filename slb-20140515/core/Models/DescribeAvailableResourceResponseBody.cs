// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The zones and the supported resources.</para>
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
                /// <para>The primary zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai-a</para>
                /// </summary>
                [NameInMap("MasterZoneId")]
                [Validation(Required=false)]
                public string MasterZoneId { get; set; }

                /// <summary>
                /// <para>The secondary zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai-b</para>
                /// </summary>
                [NameInMap("SlaveZoneId")]
                [Validation(Required=false)]
                public string SlaveZoneId { get; set; }

                /// <summary>
                /// <para>The supported resources.</para>
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
                        /// <para>The type of the IP address.</para>
                        /// <para>Valid values: <b>ipv4 and ipv6</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ipv4</para>
                        /// </summary>
                        [NameInMap("AddressIPVersion")]
                        [Validation(Required=false)]
                        public string AddressIPVersion { get; set; }

                        /// <summary>
                        /// <para>The network type.</para>
                        /// <para>Valid values: <b>vpc, classic-internet, and classic-intranet</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>classic_internet</para>
                        /// </summary>
                        [NameInMap("AddressType")]
                        [Validation(Required=false)]
                        public string AddressType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173B0EEA-22ED-4EE2-91F9-3A1CDDFFBBBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
