// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to overwrite existing resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The resources submitted this time overwrite the previously associated resources.</description></item>
        /// <item><description>false: The resources submitted this time do not overwrite the previously associated resources. The associated resources after submission include the previously associated resources and the resources submitted this time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public string Overwrite { get; set; }

        /// <summary>
        /// <para>The resources that are associated with the alert rule. Set the value to a JSON array.</para>
        /// <remarks>
        /// <para> You can add up to 100 resources each time. An alert rule can be associated with up to 3,000 resources.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;instanceId&quot;:&quot;i-a2d5q7pm3f9yr29e****&quot;}]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2ze3w55tr2rcpejpcfap_59c96b85-0339-4f35-ba66-ae4e34d3****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
