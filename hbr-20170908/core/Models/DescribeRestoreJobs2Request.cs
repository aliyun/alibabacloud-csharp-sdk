// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeRestoreJobs2Request : TeaModel {
        /// <summary>
        /// <para>The edition. Valid values: <c>BASIC</c> and <c>STANDARD</c>. Default value: <c>STANDARD</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeRestoreJobs2RequestFilters> Filters { get; set; }
        public class DescribeRestoreJobs2RequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RegionId</b>: region ID</para>
            /// </description></item>
            /// <item><description><para><b>PlanId</b>: backup plan ID</para>
            /// </description></item>
            /// <item><description><para><b>JobId</b>: backup job ID</para>
            /// </description></item>
            /// <item><description><para><b>VaultId</b>: vault ID</para>
            /// </description></item>
            /// <item><description><para><b>InstanceId</b>: ECS instance ID</para>
            /// </description></item>
            /// <item><description><para><b>Bucket</b>: OSS bucket name</para>
            /// </description></item>
            /// <item><description><para><b>FileSystemId</b>: file system ID</para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: job status</para>
            /// </description></item>
            /// <item><description><para><b>CompleteTime</b>: completion time</para>
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
            /// <para>The matching method. The default value is IN. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>EQUAL</b>: Equal to</para>
            /// </description></item>
            /// <item><description><para><b>NOT_EQUAL</b>: Not equal to</para>
            /// </description></item>
            /// <item><description><para><b>GREATER_THAN</b>: Greater than</para>
            /// </description></item>
            /// <item><description><para><b>GREATER_THAN_OR_EQUAL</b>: Greater than or equal to</para>
            /// </description></item>
            /// <item><description><para><b>LESS_THAN</b>: Less than</para>
            /// </description></item>
            /// <item><description><para><b>LESS_THAN_OR_EQUAL</b>: Less than or equal to</para>
            /// </description></item>
            /// <item><description><para><b>BETWEEN</b>: The value is within a specified range. The <c>Values</c> parameter must be a JSON array in the <c>[min, max]</c> format.</para>
            /// </description></item>
            /// <item><description><para><b>IN</b>: The value is in a specified set. The <c>Values</c> parameter must be an array.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The IN operator is not supported when <c>Key</c> is <b>CompleteTime</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>An array of values for the specified filter key.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ECS_FILE</b>: Restores ECS files.</para>
        /// </description></item>
        /// <item><description><para><b>OSS</b>: Restores OSS objects.</para>
        /// </description></item>
        /// <item><description><para><b>NAS</b>: Restores NAS files.</para>
        /// </description></item>
        /// <item><description><para><b>COMMON_FILE_SYSTEM</b>: Restores data to a CPFS file system.</para>
        /// </description></item>
        /// <item><description><para><b>OTS_TABLE</b>: Restores an OTS table.</para>
        /// </description></item>
        /// <item><description><para><b>UDM_ECS_ROLLBACK</b>: Restores an entire ECS instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

    }

}
