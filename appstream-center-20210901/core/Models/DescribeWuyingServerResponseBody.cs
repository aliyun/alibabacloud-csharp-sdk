// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeWuyingServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the development workstation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWuyingServerResponseBodyData Data { get; set; }
        public class DescribeWuyingServerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BizRegionId")]
            [Validation(Required=false)]
            public string BizRegionId { get; set; }

            /// <summary>
            /// <para>The billing type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the workstation was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The maximum number of private IP addresses per ENI, including the primary IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EniPrivateIpAddressQuantity")]
            [Validation(Required=false)]
            public int? EniPrivateIpAddressQuantity { get; set; }

            /// <summary>
            /// <para>The time when the workstation expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-bp1234567890abcde</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ubuntu 22.04</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The internal IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.1</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-abc123</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default Workspace.</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The workspace type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Simple</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>The operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The set of private IP addresses, including the primary and secondary IP addresses.</para>
            /// </summary>
            [NameInMap("PrivateIpSets")]
            [Validation(Required=false)]
            public List<DescribeWuyingServerResponseBodyDataPrivateIpSets> PrivateIpSets { get; set; }
            public class DescribeWuyingServerResponseBodyDataPrivateIpSets : TeaModel {
                /// <summary>
                /// <para>Indicates whether the IP address is the primary private IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The IP address is the primary private IP address.</description></item>
                /// <item><description>false: The IP address is a secondary private IP address.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// <para>The private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.1</para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

            }

            /// <summary>
            /// <para>The status of the development workstation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the development workstation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-bp1234567890abcde</para>
            /// </summary>
            [NameInMap("WuyingServerId")]
            [Validation(Required=false)]
            public string WuyingServerId { get; set; }

            /// <summary>
            /// <para>The name of the development workstation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-dev-server</para>
            /// </summary>
            [NameInMap("WuyingServerName")]
            [Validation(Required=false)]
            public string WuyingServerName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
