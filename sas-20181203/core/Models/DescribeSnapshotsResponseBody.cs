// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSnapshotsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSnapshotsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The token that is used to initiate the next call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAGYXFWIAAAAACjMDLgAAADFTNzMyZDMwMzAzMDM1Mzc3Njc4MzA2ODY5NmI2YTY1Nzg2NTcxNjE2NDc4****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB393****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the backup snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The actual data amount of backup snapshots after duplicates are removed. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>686188****</para>
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public long? ActualBytes { get; set; }

            /// <summary>
            /// <para>The actual number of backup objects.</para>
            /// <remarks>
            /// <para> This parameter is available only for file backup.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ActualItems")]
            [Validation(Required=false)]
            public long? ActualItems { get; set; }

            /// <summary>
            /// <para>The actual amount of data that is generated by incremental backup. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("BytesDone")]
            [Validation(Required=false)]
            public long? BytesDone { get; set; }

            /// <summary>
            /// <para>The total data amount of the data source. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3484541815****</para>
            /// </summary>
            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// <para>This parameter is returned only if the value of the <b>SourceType</b> parameter is <b>ECS_FILE</b>. This parameter indicates the ID of the Hybrid Backup Recovery (HBR) agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000dbefaw9f7gnbw****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The version of the anti-ransomware agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.10.0</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1646793988</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The file that records the information about backup failures, including the information about partially completed backup tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-0008ndhgrflh55i5****.csv</para>
            /// </summary>
            [NameInMap("ErrorFile")]
            [Validation(Required=false)]
            public string ErrorFile { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze78zfakirgh1yl****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of backup objects.</para>
            /// <remarks>
            /// <para> This parameter is available only for file backup.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ItemsDone")]
            [Validation(Required=false)]
            public long? ItemsDone { get; set; }

            /// <summary>
            /// <para>The total number of objects in the data source.</para>
            /// <remarks>
            /// <para> This parameter is available only for file backup.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ItemsTotal")]
            [Validation(Required=false)]
            public long? ItemsTotal { get; set; }

            /// <summary>
            /// <para>The ID of the backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-000a2q5vg6awgo01****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The hash value of the parent backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a0181606689c9562f092b3190bddb8a62bb5a24784424ba2102bc7fe92ae****</para>
            /// </summary>
            [NameInMap("ParentSnapshotHash")]
            [Validation(Required=false)]
            public string ParentSnapshotHash { get; set; }

            /// <summary>
            /// <para>This parameter is returned only if the value of the <b>SourceType</b> parameter is <b>ECS_FILE</b>. This parameter indicates the path to the backup files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/home&quot;]</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>This parameter is returned only if the value of the <b>SourceType</b> parameter is <b>NAS</b>. This parameter indicates the path to the backup files.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The ID of the backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-000ee8gh2ljelsnb****</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The ID of the region in which backup snapshot is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-1</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The retention period of the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>The hash value of the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9ee47cf12351e4ddecce8c12f4957d3946cd96fbe24cd4ab264c7200839d****</para>
            /// </summary>
            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            /// <summary>
            /// <para>The ID of the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-0003ahfuqpjdztsg****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_FILE</b>: ECS files</description></item>
            /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets</description></item>
            /// <item><description><b>NAS</b>: File Storage NAS file systems</description></item>
            /// <item><description><b>OTS_TABLE</b>: Tablestore instances</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_FILE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The status of backup tasks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMPLETE</b>: complete</description></item>
            /// <item><description><b>PARTIAL_COMPLETE</b>: partial complete</description></item>
            /// <item><description><b>FAILED</b>: failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d332af48-1269-4a55-a6db-8543a80f****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the backup vault that stores the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-000ccok3zmw7fbzz****</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

    }

}
