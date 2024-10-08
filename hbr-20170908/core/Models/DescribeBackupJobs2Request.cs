// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupJobs2Request : TeaModel {
        /// <summary>
        /// <para>The keys in the filter.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeBackupJobs2RequestFilters> Filters { get; set; }
        public class DescribeBackupJobs2RequestFilters : TeaModel {
            /// <summary>
            /// <para>The key in the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RegionId</b>: the ID of a region</description></item>
            /// <item><description><b>PlanId</b>: the ID of a backup plan</description></item>
            /// <item><description><b>JobId</b>: the ID of a backup job</description></item>
            /// <item><description><b>VaultId</b>: the ID of a backup vault</description></item>
            /// <item><description><b>InstanceId</b>: the ID of an ECS instance</description></item>
            /// <item><description><b>Bucket</b>: the name of an OSS bucket</description></item>
            /// <item><description><b>FileSystemId</b>: the ID of a file system</description></item>
            /// <item><description><b>Status</b>: the status of a backup job</description></item>
            /// <item><description><b>CreatedTime</b>: the start time of a backup job</description></item>
            /// <item><description><b>CompleteTime</b>: the end time of a backup job</description></item>
            /// <item><description><b>InstanceName</b>: the name of a Tablestore instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VaultId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching method. Default value: IN. This parameter specifies the operator that you want to use to match a key and a value in the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EQUAL</b>: equal to</description></item>
            /// <item><description><b>NOT_EQUAL</b>: not equal to</description></item>
            /// <item><description><b>GREATER_THAN</b>: greater than</description></item>
            /// <item><description><b>GREATER_THAN_OR_EQUAL</b>: greater than or equal to</description></item>
            /// <item><description><b>LESS_THAN</b>: less than</description></item>
            /// <item><description><b>LESS_THAN_OR_EQUAL</b>: less than or equal to</description></item>
            /// <item><description><b>BETWEEN</b>: specifies a JSON array as a range. The results must fall within the range in the <c>[Minimum value,Maximum value]</c> format.</description></item>
            /// <item><description><b>IN</b>: specifies an array as a collection. The results must fall within the collection.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify the <b>CompleteTime</b> parameter as a key to query backup jobs, you cannot use the IN operator to perform a match.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The variable values of the filter.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASCEND</b>: sorts the results in ascending order</description></item>
        /// <item><description><b>DESCEND</b> (default value): sorts the results in descending order</description></item>
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
        /// <item><description><b>ECS_FILE</b>: Elastic Compute Service (ECS) files</description></item>
        /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets</description></item>
        /// <item><description><b>NAS</b>: Apsara File Storage NAS file systems</description></item>
        /// <item><description><b>OTS</b>: Tablestore instances</description></item>
        /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
        /// <item><description><b>UDM_ECS_DISK</b>: ECS disks</description></item>
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
