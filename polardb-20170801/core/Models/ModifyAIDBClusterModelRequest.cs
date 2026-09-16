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
        /// <para>The new customer-facing invocation name. If this parameter is not specified, the existing invocation name is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flagship-chat</para>
        /// </summary>
        [NameInMap("DisplayModelName")]
        [Validation(Required=false)]
        public string DisplayModelName { get; set; }

        /// <summary>
        /// <para>Specifies whether to only preview the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the target model. Select a value from the ModelName values returned by the DescribeAvailableModels operation.</para>
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

    }

}
