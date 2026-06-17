// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyCostRuleRequest : TeaModel {
        /// <summary>
        /// <para>The cost in points per million cache tokens. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CacheCostPointsPerMillion")]
        [Validation(Required=false)]
        public string CacheCostPointsPerMillion { get; set; }

        /// <summary>
        /// <para>The cost rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>924d450014e64e88ac6e8486f8e990**</para>
        /// </summary>
        [NameInMap("CostRuleId")]
        [Validation(Required=false)]
        public string CostRuleId { get; set; }

        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The cost in points per million input tokens. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InputCostPointsPerMillion")]
        [Validation(Required=false)]
        public string InputCostPointsPerMillion { get; set; }

        /// <summary>
        /// <para>The model name, such as gpt-4 or qwen-turbo.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gpt-4</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelServiceId")]
        [Validation(Required=false)]
        public string ModelServiceId { get; set; }

        /// <summary>
        /// <para>The cost in points per million output tokens. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OutputCostPointsPerMillion")]
        [Validation(Required=false)]
        public string OutputCostPointsPerMillion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
