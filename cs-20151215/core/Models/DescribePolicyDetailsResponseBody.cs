// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The governance action of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>enforce</c>: blocks non-compliant deployments.</description></item>
        /// <item><description><c>inform</c>: generates alerts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enforce</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The rule templatetype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-general</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The description of the rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Requires container images to begin with a repo string from a specified list</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the rule is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The rule is not deleted.</description></item>
        /// <item><description>1: The rule is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("is_deleted")]
        [Validation(Required=false)]
        public int? IsDeleted { get; set; }

        /// <summary>
        /// <para>The name of the policy governance rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACKAllowedRepos</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether policy configuration is required. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>0: Parameter settings are required.</description></item>
        /// <item><description>1: No parameter settings are required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("no_config")]
        [Validation(Required=false)]
        public int? NoConfig { get; set; }

        /// <summary>
        /// <para>The governance severity level of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>high</c>: high risk.</description></item>
        /// <item><description><c>medium</c>: medium risk.</description></item>
        /// <item><description><c>low</c>: low risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The details of the rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>详情请参见请求示例</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
