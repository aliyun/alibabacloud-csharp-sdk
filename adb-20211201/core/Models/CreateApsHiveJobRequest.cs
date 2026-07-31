// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsHiveJobRequest : TeaModel {
        /// <summary>
        /// <para>The advanced configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AdvancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfig { get; set; }

        /// <summary>
        /// <para>The policy for handling databases and tables with the same name at the destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intercept: reports error and aborts.
        /// Ignore: ignores and continues.
        /// Skip: skips relevant tables.</para>
        /// </summary>
        [NameInMap("ConflictStrategy")]
        [Validation(Required=false)]
        public string ConflictStrategy { get; set; }

        /// <summary>
        /// <para>The AnalyticDB for MySQL cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public long? DatasourceId { get; set; }

        /// <summary>
        /// <para>The number of AnalyticDB compute units (ACUs) required for the migration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("FullComputeUnit")]
        [Validation(Required=false)]
        public string FullComputeUnit { get; set; }

        /// <summary>
        /// <para>The destination lakehouse address, which is a full OSS path.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OssLocation")]
        [Validation(Required=false)]
        public string OssLocation { get; set; }

        /// <summary>
        /// <para>The number of parallel tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public int? Parallelism { get; set; }

        /// <summary>
        /// <para>The region ID of the O&amp;M event.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the regions and zones supported by AnalyticDB for MySQL, including region IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The expression that specifies the objects allowed for synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("SyncAllowExpression")]
        [Validation(Required=false)]
        public string SyncAllowExpression { get; set; }

        /// <summary>
        /// <para>The expression that specifies the objects allowed for synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
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
        /// <para>The workload name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-20240224100253</para>
        /// </summary>
        [NameInMap("WorkloadName")]
        [Validation(Required=false)]
        public string WorkloadName { get; set; }

    }

}
