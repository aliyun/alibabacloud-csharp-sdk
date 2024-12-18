// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the managed rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the managed rule.</description></item>
        /// <item><description>false: does not enable the managed rule. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para> After you create an evaluation rule, a managed rule that has the same settings as the evaluation rule is created. After you create a resource, the managed rule can be used to continuously check the compliance of the resource.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableManagedRules")]
        [Validation(Required=false)]
        public bool? EnableManagedRules { get; set; }

        /// <summary>
        /// <para>The resources that you want to evaluate.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceEvaluateItems")]
        [Validation(Required=false)]
        public string ResourceEvaluateItemsShrink { get; set; }

    }

}
