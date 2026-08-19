// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupJobs2Request : TeaModel {
        /// <summary>
        /// <para>The edition. Valid values: BASIC and STANDARD. The default value is STANDARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the filter.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeBackupJobs2RequestFilters> Filters { get; set; }
        public class DescribeBackupJobs2RequestFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RegionId</b>: The region ID.</para>
            /// </description></item>
            /// <item><description><para><b>PlanId</b>: The backup plan ID.</para>
            /// </description></item>
            /// <item><description><para><b>JobId</b>: The backup job ID.</para>
            /// </description></item>
            /// <item><description><para><b>VaultId</b>: The repository ID.</para>
            /// </description></item>
            /// <item><description><para><b>InstanceId</b>: The ECS instance ID.</para>
            /// </description></item>
            /// <item><description><para><b>Bucket</b>: The name of the OSS bucket.</para>
            /// </description></item>
            /// <item><description><para><b>FileSystemId</b>: The file system ID.</para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: The job status.</para>
            /// </description></item>
            /// <item><description><para><b>CreatedTime</b>: The start time of the job.</para>
            /// </description></item>
            /// <item><description><para><b>CompleteTime</b>: The end time of the job.</para>
            /// </description></item>
            /// <item><description><para><b>InstanceName</b>: The name of the Tablestore instance.</para>
            /// </description></item>
            /// <item><description><para><b>BackupType</b>: The backup job. This parameter is required only when SourceType is set to COMMON_NAS.</para>
            /// </description></item>
            /// <item><description><para><b>ParentId</b>: The ID of the parent job. This parameter is required when you query sub-tasks. For example, if you set SourceType to UDM_ECS_DISK, you must specify the ID of the UDM_ECS job.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VaultId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching operator. The default value is IN. This parameter specifies the operator to use for matching the Key and Value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>EQUAL</b>: Equal to.</para>
            /// </description></item>
            /// <item><description><para><b>NOT_EQUAL</b>: Not equal to.</para>
            /// </description></item>
            /// <item><description><para><b>GREATER_THAN</b>: Greater than.</para>
            /// </description></item>
            /// <item><description><para><b>GREATER_THAN_OR_EQUAL</b>: Greater than or equal to.</para>
            /// </description></item>
            /// <item><description><para><b>LESS_THAN</b>: Less than.</para>
            /// </description></item>
            /// <item><description><para><b>LESS_THAN_OR_EQUAL</b>: Less than or equal to.</para>
            /// </description></item>
            /// <item><description><para><b>BETWEEN</b>: The value is a JSON array in the format of <c>[start,end]</c>.</para>
            /// </description></item>
            /// <item><description><para><b>IN</b>: The value is an array.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The IN operator is not supported when you use <b>CompleteTime</b> as the key for a query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The value of the filter.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ASCEND</b>: Ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>DESCEND</b> (Default): Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESCEND</para>
        /// </summary>
        [NameInMap("SortDirection")]
        [Validation(Required=false)]
        public string SortDirection { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ECS_FILE</b>: Backs up Elastic Compute Service (ECS) files.</para>
        /// </description></item>
        /// <item><description><para><b>OSS</b>: Backs up Alibaba Cloud Object Storage Service (OSS) buckets.</para>
        /// </description></item>
        /// <item><description><para><b>NAS</b>: Backs up Alibaba Cloud Apsara File Storage NAS (NAS) file systems.</para>
        /// </description></item>
        /// <item><description><para><b>OTS</b>: Backs up Alibaba Cloud Tablestore instances.</para>
        /// </description></item>
        /// <item><description><para><b>UDM_ECS</b>: Backs up entire ECS instances.</para>
        /// </description></item>
        /// <item><description><para><b>UDM_ECS_DISK</b>: A sub-task for disk backup in an ECS instance backup job.</para>
        /// </description></item>
        /// <item><description><para><b>COMMON_NAS</b>: A generic NAS data source. This includes archive NAS and on-premises NAS data sources. Use the Values parameter of Filters to specify the data source type.</para>
        /// </description></item>
        /// <item><description><para><b>File</b>: Backs up on-premises files.</para>
        /// </description></item>
        /// <item><description><para><b>SYNC</b>: Data synchronization.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
