// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the queried simple application servers.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The status of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: The server is normal.</description></item>
            /// <item><description>Expired: The server expires.</description></item>
            /// <item><description>Overdue: The payment of the server is overdue.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The billing method of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Indicates whether the simple application server uses a bundle plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Combination")]
            [Validation(Required=false)]
            public bool? Combination { get; set; }

            /// <summary>
            /// <para>The ID of the simple application server that uses a bundle plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com-f6c9a22****45b5b8de68ad608af1ba</para>
            /// </summary>
            [NameInMap("CombinationInstanceId")]
            [Validation(Required=false)]
            public string CombinationInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the simple application server was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-08T05:31:06Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The DDoS protection status of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: The DDoS protection status of the server is normal.</description></item>
            /// <item><description>BlackHole: The server is in blackhole filtering.</description></item>
            /// <item><description>Defense: The server is being scrubbed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("DdosStatus")]
            [Validation(Required=false)]
            public string DdosStatus { get; set; }

            /// <summary>
            /// <para>The reason why the server is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FINANCIAL: The server is locked due to overdue payments.</description></item>
            /// <item><description>SECURITY: The server is locked for security reasons.</description></item>
            /// <item><description>EXPIRED: The server is expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXPIRED</para>
            /// </summary>
            [NameInMap("DisableReason")]
            [Validation(Required=false)]
            public string DisableReason { get; set; }

            /// <summary>
            /// <para>The information about the disks on the simple application server.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesDisks> Disks { get; set; }
            public class ListInstancesResponseBodyInstancesDisks : TeaModel {
                /// <summary>
                /// <para>The category of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ESSD: ESSD of PL0</description></item>
                /// <item><description>SSD: standard SSD</description></item>
                /// <item><description>CLOUD_EFFICIENCY: an ultra disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ESSD</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The time when the simple application server was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-24T02:20:10Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The device name of the disk after the disk is attached to the simple application server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/xvda</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The billing method of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// <para>The disk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp14wq0149cpp2x****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The disk name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SystemDisk</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>The tags that are added to the disk.</para>
                /// </summary>
                [NameInMap("DiskTags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesDisksDiskTags> DiskTags { get; set; }
                public class ListInstancesResponseBodyInstancesDisksDiskTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestValue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The type of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system disk.</description></item>
                /// <item><description>data: data disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The remarks of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>remark</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the disk belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2bti7cf7****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The size of the disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The status of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ReIniting: The disk is being initialized.</description></item>
                /// <item><description>Creating: The disk is being created.</description></item>
                /// <item><description>In_use: The disk is in use.</description></item>
                /// <item><description>Available: The disk can be attached.</description></item>
                /// <item><description>Attaching: The disk is being attached.</description></item>
                /// <item><description>Detaching: The disk is being detached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>In_use</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The time when the simple application server expires. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesImage Image { get; set; }
            public class ListInstancesResponseBodyInstancesImage : TeaModel {
                /// <summary>
                /// <para>The image provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://selfs****e.console.aliyun.com/ticket/createIndex">https://selfs****e.console.aliyun.com/ticket/createIndex</a></para>
                /// </summary>
                [NameInMap("ImageContact")]
                [Validation(Required=false)]
                public string ImageContact { get; set; }

                /// <summary>
                /// <para>The URL of the image icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i3/O****1vdh9651ReKqWNMI2I_!!6000000002136****-24-24.svg">https://img.alicdn.com/imgextra/i3/O****1vdh9651ReKqWNMI2I_!!6000000002136****-24-24.svg</a></para>
                /// </summary>
                [NameInMap("ImageIconUrl")]
                [Validation(Required=false)]
                public string ImageIconUrl { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-custom-1686536882356</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The type of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system</description></item>
                /// <item><description>app</description></item>
                /// <item><description>custom</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// <para>The image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V3.5</para>
                /// </summary>
                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                /// <summary>
                /// <para>The OS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe9c66133a9d4688872869726b52****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The private IP address of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.26.XX.XX</para>
            /// </summary>
            [NameInMap("InnerIpAddress")]
            [Validation(Required=false)]
            public string InnerIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2ad1ae67295445f598017499dc****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-InstanceName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("NetworkAttributes")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesNetworkAttributes> NetworkAttributes { get; set; }
            public class ListInstancesResponseBodyInstancesNetworkAttributes : TeaModel {
                [NameInMap("PeakBandwidth")]
                [Validation(Required=false)]
                public int? PeakBandwidth { get; set; }

                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }

                [NameInMap("PublicIpDdosStatus")]
                [Validation(Required=false)]
                public string PublicIpDdosStatus { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swas.s2.c2m2s50b4t08</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42.1.XX.XX</para>
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the server belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz7jmhg5s****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The specifications of the resources on the simple application server.</para>
            /// </summary>
            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesResourceSpec ResourceSpec { get; set; }
            public class ListInstancesResponseBodyInstancesResourceSpec : TeaModel {
                /// <summary>
                /// <para>The bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The number of vCPUs of the simple application server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The category of the disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ESSD: enhanced SSD (ESSD) of PL0</description></item>
                /// <item><description>SSD: standard SSD</description></item>
                /// <item><description>CLOUD_EFFICIENCY: ultra disk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                /// <summary>
                /// <para>The size of the disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// <para>The amount of the traffic.</para>
                /// <list type="bullet">
                /// <item><description>A value of 0 indicates the traffic amount of a bandwidth-based simple application server.</description></item>
                /// <item><description>A non-zero value indicates the traffic amount of a data transfer plan-based simple application server.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>818</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public double? Flow { get; set; }

                /// <summary>
                /// <para>The size of the memory. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public double? Memory { get; set; }

            }

            /// <summary>
            /// <para>The status of the simple application server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The server is being prepared.</description></item>
            /// <item><description>Starting: The server is being started.</description></item>
            /// <item><description>Running: The server is running.</description></item>
            /// <item><description>Stopping: The server is being stopped.</description></item>
            /// <item><description>Stopped: The server is stopped.</description></item>
            /// <item><description>Resetting: The server is being reset.</description></item>
            /// <item><description>Upgrading: The server is being upgraded.</description></item>
            /// <item><description>Disabled: The server is not available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags that are added to the simple application server.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class ListInstancesResponseBodyInstancesTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the simple application server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the simple application server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The universally unique identifier (UUID) of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41f30524-5df7-49c9-9c6e-32****489001</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
