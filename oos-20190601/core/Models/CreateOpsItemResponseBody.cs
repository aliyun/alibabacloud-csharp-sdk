// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateOpsItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the O\&amp;M item.</para>
        /// </summary>
        [NameInMap("OpsItem")]
        [Validation(Required=false)]
        public CreateOpsItemResponseBodyOpsItem OpsItem { get; set; }
        public class CreateOpsItemResponseBodyOpsItem : TeaModel {
            /// <summary>
            /// <para>The attributes of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;regionId\&quot;:\&quot;cn-zhangjiakou\&quot;,\&quot;appId\&quot;:\&quot;992BKO1X75GRQ4E8\&quot;,\&quot;instanceId\&quot;:\&quot;i-8vbcymxagqsyyyjppbr4\&quot;,\&quot;instance_name\&quot;:\&quot;cdae\&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>The category of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M item was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-24T03:55Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The user who created the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The description of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpsItem</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The user who last modified the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("LastModifiedBy")]
            [Validation(Required=false)]
            public string LastModifiedBy { get; set; }

            /// <summary>
            /// <para>The ID of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oi-dba9c6eec9254a4d87c1</para>
            /// </summary>
            [NameInMap("OpsItemId")]
            [Validation(Required=false)]
            public string OpsItemId { get; set; }

            /// <summary>
            /// <para>The priority of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

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
            /// <para>The ARNs of the associated resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;acs:oos:cn-hangzhou:1563457855438522:application/dingTest/applicationgroup/fltest\&quot;]</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// <para>The severity level of the O\&amp;M item.</para>
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
            /// <para>[{\n \\&quot;priority\\&quot;:3,\n \\&quot;type\\&quot;:\\&quot;url\\&quot;,\n \\&quot;url\\&quot;:\\&quot;<a href="https://example..com%5C%5C%5C%5C%22,%5C%5Cn">https://example..com\\\\&quot;,\\n</a> \\&quot;description\\&quot;:\\&quot;Specify a cross-zone high availability cluster. \\&quot;\n}]</para>
            /// </summary>
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public string Solutions { get; set; }

            /// <summary>
            /// <para>The source business of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/aliyun/ecs</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The state of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;: &quot;v1&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The title of the O\&amp;M item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS reboot is scheduled</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M item was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-24T03:55Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA4F08D4-DA54-5407-84B9-108C71D75B17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
