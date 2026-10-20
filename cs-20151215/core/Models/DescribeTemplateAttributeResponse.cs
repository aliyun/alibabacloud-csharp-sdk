// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplateAttributeResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeTemplateAttributeResponseBody> Body { get; set; }
        public class DescribeTemplateAttributeResponseBody : TeaModel {
            /// <summary>
            /// <para>The orchestration template ID. A new ID is generated each time the template is modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72d20cf8-a533-4ea9-a10d-e7630d3d****</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The access permissions of the orchestration template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>private</c>: private.</description></item>
            /// <item><description><c>public</c>: public.</description></item>
            /// <item><description><c>shared</c>: shared.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>The name of the orchestration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The YAML content of the orchestration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: V1\n***</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The templatetype.</para>
            /// <list type="bullet">
            /// <item><description><para>If the value is kubernetes, the template is displayed on the Orchestration Templates page in the console.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is not set or is set to other values, the template is not displayed on the Orchestration Templates page in the console.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kubernetes</para>
            /// </summary>
            [NameInMap("template_type")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The description of the orchestration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The tags of the deployment template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sa</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The unique ID of the orchestration template. This ID does not change when the template is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>874ec485-e7e6-4373-8a3b-47bde8ae****</para>
            /// </summary>
            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            /// <summary>
            /// <para>The time when the orchestration template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25T16:56:33+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The time when the orchestration template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25T16:56:33+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
