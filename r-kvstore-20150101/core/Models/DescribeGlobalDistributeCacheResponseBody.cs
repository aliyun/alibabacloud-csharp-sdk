// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalDistributeCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of distributed instances.</para>
        /// </summary>
        [NameInMap("GlobalDistributeCaches")]
        [Validation(Required=false)]
        public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches> GlobalDistributeCaches { get; set; }
        public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches : TeaModel {
            /// <summary>
            /// <para>The instance ID of the distributed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gr-bp14rkqrhac****</para>
            /// </summary>
            [NameInMap("GlobalInstanceId")]
            [Validation(Required=false)]
            public string GlobalInstanceId { get; set; }

            /// <summary>
            /// <para>The instance status of the distributed instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The instance is running.</description></item>
            /// <item><description><b>Changing</b>: The instance is being modified.</description></item>
            /// <item><description><b>Creating</b>: The instance is being created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of child instances.</para>
            /// </summary>
            [NameInMap("SubInstances")]
            [Validation(Required=false)]
            public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances> SubInstances { get; set; }
            public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances : TeaModel {
                /// <summary>
                /// <para>The instance ID of the distributed instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gr-bp14rkqrhac****</para>
                /// </summary>
                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                /// <summary>
                /// <para>The instance type of the child instance. For more information, see:</para>
                /// <list type="bullet">
                /// <item><description><a href="https://help.aliyun.com/document_detail/145228.html">Standard memory-optimized instance types</a>.</description></item>
                /// <item><description><a href="https://help.aliyun.com/document_detail/150458.html">Cluster memory-optimized instance types</a>.</description></item>
                /// <item><description><a href="https://help.aliyun.com/document_detail/150459.html">Read/write splitting memory-optimized instance types</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>redis.amber.logic.sharding.2g.2db.0rodb.6proxy.multithread</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <para>The instance ID of the child instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1zxszhcgatnx****</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <para>The instance status of the child instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The instance is in a normal state.</description></item>
                /// <item><description><b>Creating</b>: The instance is being created.</description></item>
                /// <item><description><b>Changing</b>: The instance is being modified.</description></item>
                /// <item><description><b>Inactive</b>: The instance is disabled.</description></item>
                /// <item><description><b>Flushing</b>: The instance is being purged.</description></item>
                /// <item><description><b>Released</b>: The instance is released.</description></item>
                /// <item><description><b>Transforming</b>: The instance is being transformed.</description></item>
                /// <item><description><b>Unavailable</b>: The service is stopped.</description></item>
                /// <item><description><b>Error</b>: The instance failed to be created.</description></item>
                /// <item><description><b>Migrating</b>: The instance is being migrated.</description></item>
                /// <item><description><b>BackupRecovering</b>: The instance is recovering from a backup.</description></item>
                /// <item><description><b>MinorVersionUpgrading</b>: The minor version of the instance is being upgraded.</description></item>
                /// <item><description><b>NetworkModifying</b>: The network of the instance is being modified.</description></item>
                /// <item><description><b>SSLModifying</b>: The SSL certificate of the instance is being modified.</description></item>
                /// <item><description><b>MajorVersionUpgrading</b>: A major engine version upgrade is in progress. The instance remains accessible.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For more information about instance statuses and their impacts, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance statuses and impacts</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3F44BE3-5419-4B61-9BAC-E66E295A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
