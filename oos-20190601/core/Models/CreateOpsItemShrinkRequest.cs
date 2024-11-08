// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateOpsItemShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The category.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Availability</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Performance</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Security</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Cost</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Recovery</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e56767-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The string to be deduplicated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_instance_Sys</para>
        /// </summary>
        [NameInMap("DedupString")]
        [Validation(Required=false)]
        public string DedupString { get; set; }

        /// <summary>
        /// <para>The description of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpsItem</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The priority. Valid values: 1 to 5. 1 indicates the highest priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Names (ARNs) of the associated resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;acs:oos:cn-hangzhou:1563457855438522:application/test-33333/applicationgroup/default-cn-hangzhou-1\&quot;]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>High</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Low</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Medium</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Critical</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Medium</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The solutions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\n \\&quot;priority\\&quot;:3,\n \\&quot;type\\&quot;:\\&quot;SingleAZEcs\\&quot;,\n \\&quot;url\\&quot;:\\&quot;<a href="http://ecs.consle.aliyuncs.com%5C%5C%5C%5C%22,%5C%5Cn">http://ecs.consle.aliyuncs.com\\\\&quot;,\\n</a> \\&quot;description\\&quot;:\\&quot;Create Elastic Compute Service (ECS) instances in different zones and import them to an application group.\\&quot;\n}]</para>
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public string Solutions { get; set; }

        /// <summary>
        /// <para>The source business.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/aliyun/ecs</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;k1&quot;: &quot;v1&quot;,
        ///       &quot;k2&quot;: &quot;v2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The title of the O\&amp;M item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS reboot is scheduled</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
