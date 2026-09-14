// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeLensMonitorDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud disk information.</para>
        /// </summary>
        [NameInMap("DiskInfos")]
        [Validation(Required=false)]
        public List<DescribeLensMonitorDisksResponseBodyDiskInfos> DiskInfos { get; set; }
        public class DescribeLensMonitorDisksResponseBodyDiskInfos : TeaModel {
            /// <summary>
            /// <para>The maximum data throughput for read/write (I/O) operations per second. Unit: MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public int? Bps { get; set; }

            /// <summary>
            /// <para>Indicates whether burst (performance bursting) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disk</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The cloud disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: Enterprise SSD (ESSD).</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL cloud disk.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

            /// <summary>
            /// <para>The cloud disk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-cd401****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The cloud disk name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk-28c6b****</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The cloud disk status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: in use.</description></item>
            /// <item><description>Deleted: deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("DiskStatus")]
            [Validation(Required=false)]
            public string DiskStatus { get; set; }

            /// <summary>
            /// <para>The cloud disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system cloud disk.</description></item>
            /// <item><description>data: data cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The maximum number of read/write (I/O) operations per second. Unit: operations/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// <para>The collection of event tags for the cloud disk. Event tags display events that occurred on the cloud disk within the last 24 hours, with a delay of up to 1 hour compared to the actual events.</para>
            /// </summary>
            [NameInMap("LensTags")]
            [Validation(Required=false)]
            public List<string> LensTags { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the ESSD cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: maximum random read/write IOPS of 10,000 per standard SSD.</description></item>
            /// <item><description>PL1: maximum random read/write IOPS of 50,000 per standard SSD.</description></item>
            /// <item><description>PL2: maximum random read/write IOPS of 100,000 per standard SSD.</description></item>
            /// <item><description>PL3: maximum random read/write IOPS of 1,000,000 per standard SSD.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL cloud disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disk</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public int? ProvisionedIops { get; set; }

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
            /// <para>Indicates whether the cloud disk is a shared cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SharingEnabled")]
            [Validation(Required=false)]
            public string SharingEnabled { get; set; }

            /// <summary>
            /// <para>The cloud disk size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The collection of tags for the cloud disk.</para>
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
            /// <para>The zone ID of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID. A request ID is returned regardless of whether the API call succeeds.</para>
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
