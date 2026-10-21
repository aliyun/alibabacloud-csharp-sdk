// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyAIDBClusterModelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB AI 3.0 logical instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-2ze4x2mwo81knj08a</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The new customer-facing invocation name. If you do not specify this parameter, the existing invocation name is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flagship-chat</para>
        /// </summary>
        [NameInMap("DisplayModelName")]
        [Validation(Required=false)]
        public string DisplayModelName { get; set; }

        /// <summary>
        /// <para>Specifies whether to only preview the modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The target model name. Select a value from the ModelName values returned by DescribeAvailableModels.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-32B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The worker restart mode. Valid values: inPlace and recreate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inPlace</para>
        /// </summary>
        [NameInMap("RestartMode")]
        [Validation(Required=false)]
        public string RestartMode { get; set; }

        /// <summary>
        /// <para>The maximum number of workers to restart per batch within a single MSD. Valid values: 1 to 30. This parameter takes effect only when RestartMode is set to inPlace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("WorkerBatchSize")]
        [Validation(Required=false)]
        public long? WorkerBatchSize { get; set; }

    }

}
