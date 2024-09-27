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
            /// <para>The ID of the template. When you update a template, a new template ID is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72d20cf8-a533-4ea9-a10d-e7630d3d****</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The access control policy of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The template content in the YAML format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: V1\n***</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The type of template. The value can be a custom value.</para>
            /// <list type="bullet">
            /// <item><description>If the parameter is set to <c>kubernetes</c>, the template is displayed on the Templates page in the console.</description></item>
            /// <item><description>If the parameter is set to <c>compose</c>, the template is displayed on the Container Service - Swarm page in the console. Container Service for Swarm is deprecated.</description></item>
            /// <item><description>If the value of the parameter is not <c>kubernetes</c>, the template is not displayed on the Templates page in the console. We recommend that you set the parameter to <c>kubernetes</c>.</description></item>
            /// </list>
            /// <para>Default value: <c>kubernetes</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubernetes</para>
            /// </summary>
            [NameInMap("template_type")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The label of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sa</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The unique ID of the template. The value remains unchanged after the template is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>874ec485-e7e6-4373-8a3b-47bde8ae****</para>
            /// </summary>
            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-16T19:21:29+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The time when the template was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-16T19:21:29+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
