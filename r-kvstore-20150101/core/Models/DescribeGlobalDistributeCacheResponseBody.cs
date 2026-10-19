// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalDistributeCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the distributed instance.</para>
        /// </summary>
        [NameInMap("GlobalDistributeCaches")]
        [Validation(Required=false)]
        public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches> GlobalDistributeCaches { get; set; }
        public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches : TeaModel {
            /// <summary>
            /// <para>The distributed instance ID.</para>
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
            /// <item><description><b>Normal</b>: Running.</description></item>
            /// <item><description><b>Changing</b>: Being modified.</description></item>
            /// <item><description><b>Creating</b>: Being created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The details of the child instances.</para>
            /// </summary>
            [NameInMap("SubInstances")]
            [Validation(Required=false)]
            public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances> SubInstances { get; set; }
            public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances : TeaModel {
                /// <summary>
                /// <para>The distributed instance ID.</para>
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
                /// <item><description><a href="https://help.aliyun.com/document_detail/145228.html">Memory-optimized Standard Edition instance types</a>.</description></item>
                /// <item><description><a href="https://help.aliyun.com/document_detail/150458.html">Memory-optimized Cluster Edition instance types</a>.</description></item>
                /// <item><description><a href="https://help.aliyun.com/document_detail/150459.html">Memory-optimized read/write splitting instance types</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>redis.amber.logic.sharding.2g.2db.0rodb.6proxy.multithread</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <para>The child instance ID.</para>
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
                /// <item><description><b>Normal</b>: Normal.</description></item>
                /// <item><description><b>Creating</b>: Being created.</description></item>
                /// <item><description><b>Changing</b>: Being modified.</description></item>
                /// <item><description><b>Inactive</b>: Disabled.</description></item>
                /// <item><description><b>Flushing</b>: Being purged.</description></item>
                /// <item><description><b>Released</b>: Released.</description></item>
                /// <item><description><b>Transforming</b>: Being transformed.</description></item>
                /// <item><description><b>Unavailable</b>: Service stopped.</description></item>
                /// <item><description><b>Error</b>: Failed to create.</description></item>
                /// <item><description><b>Migrating</b>: Being migrated.</description></item>
                /// <item><description><b>BackupRecovering</b>: Being restored from a backup.</description></item>
                /// <item><description><b>MinorVersionUpgrading</b>: Minor version being upgraded.</description></item>
                /// <item><description><b>NetworkModifying</b>: Network being modified.</description></item>
                /// <item><description><b>SSLModifying</b>: SSL being modified.</description></item>
                /// <item><description><b>MajorVersionUpgrading</b>: Major engine version upgrade in progress. The instance can be accessed normally.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For more information about instance status and details, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance states and impacts</a>.</para>
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
        /// <para>The number of entries that can be displayed per page.</para>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
