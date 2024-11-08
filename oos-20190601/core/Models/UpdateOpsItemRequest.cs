// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateOpsItemRequest : TeaModel {
        /// <summary>
        /// <para>The category.</para>
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
        /// <para>DASKJJLKADS-AHKLJHJSAKL-AJK</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The string to be deduplicated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_instance_SystemMaintenance.Reboot</para>
        /// </summary>
        [NameInMap("DedupString")]
        [Validation(Required=false)]
        public string DedupString { get; set; }

        /// <summary>
        /// <para>The description of the O\&amp;M item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-update</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the O\&amp;M item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oi-e2264dcf040c472598e9</para>
        /// </summary>
        [NameInMap("OpsItemId")]
        [Validation(Required=false)]
        public string OpsItemId { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
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
        /// <para>The Alibaba Resource Names (ARNs) of the associated resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;arn:acs:ecs:cn-heyuan:1139354755361920:instance/i-f8z928h7aqotd3o65032\&quot;]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
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
        /// <para>[{\n \\&quot;priority\\&quot;:3,\n \\&quot;type\\&quot;:\\&quot;url\\&quot;,\n \\&quot;url\\&quot;:\\&quot;<a href="https://example.com%5C%5C%5C%5C%22,%5C%5Cn">https://example.com\\\\&quot;,\\n</a> \\&quot;description\\&quot;:\\&quot;Specify a cross-zone high availability cluster. \\&quot;\n}]</para>
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public string Solutions { get; set; }

        /// <summary>
        /// <para>The source business.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/aliyun/ecs</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

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
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The title of the O\&amp;M item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
