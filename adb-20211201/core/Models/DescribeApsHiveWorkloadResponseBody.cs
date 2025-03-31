// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsHiveWorkloadResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried job.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ApsWorkload")]
        [Validation(Required=false)]
        public DescribeApsHiveWorkloadResponseBodyApsWorkload ApsWorkload { get; set; }
        public class DescribeApsHiveWorkloadResponseBodyApsWorkload : TeaModel {
            /// <summary>
            /// <para>The advanced configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.adv.config=value</para>
            /// </summary>
            [NameInMap("AdvancedConfig")]
            [Validation(Required=false)]
            public string AdvancedConfig { get; set; }

            /// <summary>
            /// <para>The policy to handle tables with the same name in the destination cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intercept</para>
            /// </summary>
            [NameInMap("ConflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

            /// <summary>
            /// <para>The time when the workload was created.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-*******</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DatasourceId")]
            [Validation(Required=false)]
            public long? DatasourceId { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls-******</para>
            /// </summary>
            [NameInMap("DatasourceName")]
            [Validation(Required=false)]
            public string DatasourceName { get; set; }

            /// <summary>
            /// <para>The ID of the E-MapReduce (EMR) cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("EmrClusterId")]
            [Validation(Required=false)]
            public string EmrClusterId { get; set; }

            /// <summary>
            /// <para>The number of AnalyticDB compute units (ACUs) required for migration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("FullComputeUnit")]
            [Validation(Required=false)]
            public string FullComputeUnit { get; set; }

            /// <summary>
            /// <para>The URL of the Hive Metastore.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("MetaStoreUri")]
            [Validation(Required=false)]
            public string MetaStoreUri { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) URL of the AnalyticDB for MySQL cluster data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://******</para>
            /// </summary>
            [NameInMap("OssLocation")]
            [Validation(Required=false)]
            public string OssLocation { get; set; }

            /// <summary>
            /// <para>The number of tasks that are allowed in parallel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public long? Parallelism { get; set; }

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
            /// <para>The resource group to which the SQL statement belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The status of the workload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The expression that manually matches the source database table whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("SyncAllowExpression")]
            [Validation(Required=false)]
            public string SyncAllowExpression { get; set; }

            /// <summary>
            /// <para>Manually match the blacklist expressions for source database tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>def</para>
            /// </summary>
            [NameInMap("SyncDenyExpression")]
            [Validation(Required=false)]
            public string SyncDenyExpression { get; set; }

            /// <summary>
            /// <para>The destination type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-******</para>
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aps-******</para>
            /// </summary>
            [NameInMap("WorkloadId")]
            [Validation(Required=false)]
            public string WorkloadId { get; set; }

            /// <summary>
            /// <para>The name of the workload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadName")]
            [Validation(Required=false)]
            public string WorkloadName { get; set; }

            /// <summary>
            /// <para>The name of the workload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadTypeName")]
            [Validation(Required=false)]
            public string WorkloadTypeName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86F92D26-B774-5FA1-8E53-******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
