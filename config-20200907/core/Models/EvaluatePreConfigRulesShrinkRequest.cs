// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable rule templates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables rule templates.</para>
        /// </description></item>
        /// <item><description><para>false (default): does not enable rule templates.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableManagedRules")]
        [Validation(Required=false)]
        public bool? EnableManagedRules { get; set; }

        /// <summary>
        /// <para>An array that contains the resources that you want to evaluate.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceEvaluateItems")]
        [Validation(Required=false)]
        public string ResourceEvaluateItemsShrink { get; set; }

        /// <summary>
        /// <para>The query start token</para>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("ResourceTypeFormat")]
        [Validation(Required=false)]
        public string ResourceTypeFormat { get; set; }

    }

}
