// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The action of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>enforce</c>: blocks deployments that match the policy.</description></item>
        /// <item><description><c>inform</c>: generates alerts for deployments that match the policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enforce</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The type of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-general</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Requires container images to begin with a repo string from a specified list</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the policy is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The policy is not deleted.</description></item>
        /// <item><description>1: The policy is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("is_deleted")]
        [Validation(Required=false)]
        public int? IsDeleted { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACKAllowedRepos</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether parameters are required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Parameters are required.</description></item>
        /// <item><description>1: Parameters are optional.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("no_config")]
        [Validation(Required=false)]
        public int? NoConfig { get; set; }

        /// <summary>
        /// <para>The severity level of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>high</c></description></item>
        /// <item><description><c>medium</c></description></item>
        /// <item><description><c>low</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The content of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For more information, see sample requests.</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
