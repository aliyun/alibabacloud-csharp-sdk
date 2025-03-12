// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeRestorableTenantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the tenants.</para>
        /// </summary>
        [NameInMap("Tenants")]
        [Validation(Required=false)]
        public List<DescribeRestorableTenantsResponseBodyTenants> Tenants { get; set; }
        public class DescribeRestorableTenantsResponseBodyTenants : TeaModel {
            /// <summary>
            /// <para>The name of the backup directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup</para>
            /// </summary>
            [NameInMap("BackupBucketName")]
            [Validation(Required=false)]
            public string BackupBucketName { get; set; }

            /// <summary>
            /// <para>The list of backup sets.</para>
            /// </summary>
            [NameInMap("BackupSets")]
            [Validation(Required=false)]
            public List<DescribeRestorableTenantsResponseBodyTenantsBackupSets> BackupSets { get; set; }
            public class DescribeRestorableTenantsResponseBodyTenantsBackupSets : TeaModel {
                /// <summary>
                /// <para>The ID of the full backup set used for restore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bak-4n****gacpa8</para>
                /// </summary>
                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                /// <summary>
                /// <para>The checkpoint of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01\&quot;T\&quot;12:10:10.000\&quot;Z\&quot;</para>
                /// </summary>
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bak-xxxxx</para>
                /// </summary>
                [NameInMap("SetId")]
                [Validation(Required=false)]
                public string SetId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t5********</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>objnf3b2****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCluster</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CpuNum")]
            [Validation(Required=false)]
            public long? CpuNum { get; set; }

            /// <summary>
            /// <para>The size of memory for the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MemoryNum")]
            [Validation(Required=false)]
            public long? MemoryNum { get; set; }

            /// <summary>
            /// <para>The backup method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logical</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The version of the OceanBase Database RPM package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.3.1-2022080510****</para>
            /// </summary>
            [NameInMap("ObRpmVersion")]
            [Validation(Required=false)]
            public string ObRpmVersion { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tvd43v****</para>
            /// </summary>
            [NameInMap("ObTenantId")]
            [Validation(Required=false)]
            public string ObTenantId { get; set; }

            /// <summary>
            /// <para>The major version of OceanBase Database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.3.1</para>
            /// </summary>
            [NameInMap("ObVersion")]
            [Validation(Required=false)]
            public string ObVersion { get; set; }

            /// <summary>
            /// <para>The region of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            /// <summary>
            /// <para>The alias of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("TenantAlias")]
            [Validation(Required=false)]
            public string TenantAlias { get; set; }

            /// <summary>
            /// <para>The remaining validity period, in days, of the backup data of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TenantDataBackupRemainDays")]
            [Validation(Required=false)]
            public int? TenantDataBackupRemainDays { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The mode of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Oracle</para>
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            /// <summary>
            /// <para>The name of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sbtest1</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The list of restorable periods of the tenant.</para>
            /// </summary>
            [NameInMap("TimeIntervalList")]
            [Validation(Required=false)]
            public List<DescribeRestorableTenantsResponseBodyTenantsTimeIntervalList> TimeIntervalList { get; set; }
            public class DescribeRestorableTenantsResponseBodyTenantsTimeIntervalList : TeaModel {
                /// <summary>
                /// <para>The end time of the restorable period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-13T02:43:03Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the restore is based on archiving.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FromArchive")]
                [Validation(Required=false)]
                public bool? FromArchive { get; set; }

                /// <summary>
                /// <para>The start time of the restorable period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-20T16:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The storage type of backup data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            /// <summary>
            /// <para>The number of nodes of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

            /// <summary>
            /// <para>The size of disk space for the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("UsedDisk")]
            [Validation(Required=false)]
            public long? UsedDisk { get; set; }

        }

        /// <summary>
        /// <para>The total number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
