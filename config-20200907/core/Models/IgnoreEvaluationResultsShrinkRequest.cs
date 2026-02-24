// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class IgnoreEvaluationResultsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information about how to obtain the rule ID, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-7e72626622af0051****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>The date on which the ignored evaluation results are automatically restored.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the ignored evaluation results are not automatically restored. You must manually restore them.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-01</para>
        /// </summary>
        [NameInMap("IgnoreDate")]
        [Validation(Required=false)]
        public string IgnoreDate { get; set; }

        /// <summary>
        /// <para>The reason for ignoring the resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无需检测。</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The list of resources to be ignored.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string ResourcesShrink { get; set; }

    }

}
