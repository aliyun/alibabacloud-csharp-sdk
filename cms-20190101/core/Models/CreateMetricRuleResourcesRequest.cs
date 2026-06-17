// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to overwrite. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: overwrites. The resources submitted this time overwrite the previously associated resources. That is, full modification is performed.</para>
        /// </description></item>
        /// <item><description><para>false: does not overwrite. The resources submitted this time do not overwrite the previously associated resources (the associated resources are the historical associated resources plus the resources submitted this time). That is, incremental modification is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public string Overwrite { get; set; }

        /// <summary>
        /// <para>The associated resources. The value is in the JSON array format.</para>
        /// <remarks>
        /// <para>A maximum of 100 resource instances can be added at a time, and an alert rule can be associated with a maximum of 3,000 instances.</para>
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
