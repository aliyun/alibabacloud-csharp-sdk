// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeLensMonitorDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the disks.</para>
        /// </summary>
        [NameInMap("DiskInfos")]
        [Validation(Required=false)]
        public List<DescribeLensMonitorDisksResponseBodyDiskInfos> DiskInfos { get; set; }
        public class DescribeLensMonitorDisksResponseBodyDiskInfos : TeaModel {
            /// <summary>
            /// <para>The BPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public int? Bps { get; set; }

            /// <summary>
            /// <para>Indicates whether the performance burst feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>This parameter is available only if you set <c>DiskCategory</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The type of the disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud</description></item>
            /// <item><description>cloud_efficiency</description></item>
            /// <item><description>cloud_ssd</description></item>
            /// <item><description>cloud_essd</description></item>
            /// <item><description>cloud_auto</description></item>
            /// <item><description>cloud_essd_entry</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

            /// <summary>
            /// <para>The ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cd401****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The name of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk-28c6b****</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The disk status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available</description></item>
            /// <item><description>Deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("DiskStatus")]
            [Validation(Required=false)]
            public string DiskStatus { get; set; }

            /// <summary>
            /// <para>The disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system disk</description></item>
            /// <item><description>data: data disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// <para>Event tags of the disk.</para>
            /// </summary>
            [NameInMap("LensTags")]
            [Validation(Required=false)]
            public List<string> LensTags { get; set; }

            /// <summary>
            /// <para>The new performance level of the ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: An ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: An ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: An ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: An ESSD delivers up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk to use as the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}</para>
            /// <para>This parameter is available only if you set <c>DiskCategory</c> to <c>cloud_auto</c>. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public int? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The region ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SharingEnabled")]
            [Validation(Required=false)]
            public string SharingEnabled { get; set; }

            /// <summary>
            /// <para>The size of the disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>Tags of the disk.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLensMonitorDisksResponseBodyDiskInfosTags> Tags { get; set; }
            public class DescribeLensMonitorDisksResponseBodyDiskInfosTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
