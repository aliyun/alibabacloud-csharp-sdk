// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried disks.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public List<ListDisksResponseBodyDisks> Disks { get; set; }
        public class ListDisksResponseBodyDisks : TeaModel {
            /// <summary>
            /// <para>The category of the disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ESSD: enhanced SSD (ESSD) of PL0</description></item>
            /// <item><description>SSD: standard SSD</description></item>
            /// <item><description>CLOUD_EFFICIENCY: ultra disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ESSD</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The time when the disk was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-08T05:31:06Z</para>
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
            /// <para>The name of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDisk</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system disk</description></item>
            /// <item><description>data: data disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The ID of the simple application server to which the disk is attached.</para>
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
            /// <para>myInstance</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

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
            /// <para>The size of the disk. Unit: GB.</para>
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

            /// <summary>
            /// <para>The tags that are added to the disks.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListDisksResponseBodyDisksTags> Tags { get; set; }
            public class ListDisksResponseBodyDisksTags : TeaModel {
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
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
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
