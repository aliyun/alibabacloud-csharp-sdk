// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalDistributeCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the distributed instance.</para>
        /// </summary>
        [NameInMap("GlobalDistributeCaches")]
        [Validation(Required=false)]
        public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches> GlobalDistributeCaches { get; set; }
        public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCaches : TeaModel {
            /// <summary>
            /// <para>The ID of the distributed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gr-bp14rkqrhac****</para>
            /// </summary>
            [NameInMap("GlobalInstanceId")]
            [Validation(Required=false)]
            public string GlobalInstanceId { get; set; }

            /// <summary>
            /// <para>The state of the distributed instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The instance is normal.</description></item>
            /// <item><description><b>Changing</b>: The configurations of the instance are being changed.</description></item>
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
            /// <para>Details of the child instances.</para>
            /// </summary>
            [NameInMap("SubInstances")]
            [Validation(Required=false)]
            public List<DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances> SubInstances { get; set; }
            public class DescribeGlobalDistributeCacheResponseBodyGlobalDistributeCachesSubInstances : TeaModel {
                /// <summary>
                /// <para>The ID of the distributed instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gr-bp14rkqrhac****</para>
                /// </summary>
                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                /// <summary>
                /// <para>The instance type of the child instance. For more information, see the following topics:</para>
                /// <list type="bullet">
                /// <item><description><a href="https://help.aliyun.com/document_detail/145228.html">Standard DRAM-based instances</a></description></item>
                /// <item><description><a href="https://help.aliyun.com/document_detail/150458.html">Cluster DRAM-based instances</a></description></item>
                /// <item><description><a href="https://help.aliyun.com/document_detail/150459.html">Read/write splitting DRAM-based instances</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>redis.amber.logic.sharding.2g.2db.0rodb.6proxy.multithread</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <para>The ID of the child instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1zxszhcgatnx****</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <para>The state of the child instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The instance is normal.</description></item>
                /// <item><description><b>Creating</b>: The instance is being created.</description></item>
                /// <item><description><b>Changing</b>: The configurations of the instance are being changed.</description></item>
                /// <item><description><b>Inactive</b>: The instance is disabled.</description></item>
                /// <item><description><b>Flushing</b>: The instance is being released.</description></item>
                /// <item><description><b>Released</b>: The instance is released.</description></item>
                /// <item><description><b>Transforming</b>: The billing method of the instance is changing.</description></item>
                /// <item><description><b>Unavailable</b>: The instance is suspended.</description></item>
                /// <item><description><b>Error</b>: The instance failed to be created.</description></item>
                /// <item><description><b>Migrating</b>: The instance is being migrated.</description></item>
                /// <item><description><b>BackupRecovering</b>: The instance is being restored from a backup.</description></item>
                /// <item><description><b>MinorVersionUpgrading</b>: The minor version of the instance is being updated.</description></item>
                /// <item><description><b>NetworkModifying</b>: The network type of the instance is being changed.</description></item>
                /// <item><description><b>SSLModifying</b>: The SSL certificate of the instance is being changed.</description></item>
                /// <item><description><b>MajorVersionUpgrading</b>: The major version of the instance is being upgraded. The instance remains available during the upgrade.</description></item>
                /// </list>
                /// <remarks>
                /// <para> For more information about instance states, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance states and impacts</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
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
        /// <para>The page number of the returned page.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3F44BE3-5419-4B61-9BAC-E66E295A****</para>
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
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
