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
            /// <para>编排模板ID，每次变更都会有一个模板ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>72d20cf8-a533-4ea9-a10d-e7630d3d****</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>编排模板的访问权限，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>private</c>：私有。</description></item>
            /// <item><description><c>public</c>：公共。</description></item>
            /// <item><description><c>shared</c>：可共享。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>编排模板名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>编排模板YAML内容。</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: V1\n***</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>模板类型。</para>
            /// <list type="bullet">
            /// <item><description><para>当取值为kubernetes时将在控制台的编排模板页面展示该模板。</para>
            /// </description></item>
            /// <item><description><para>该参数不填写或者取值为其他值时，控制台的编排模板页面将不会展示该模板。</para>
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
            /// <para>编排模板描述信息。</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>部署模板的标签。</para>
            /// 
            /// <b>Example:</b>
            /// <para>sa</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>编排模板唯一ID，不随模板更新而改变。</para>
            /// 
            /// <b>Example:</b>
            /// <para>874ec485-e7e6-4373-8a3b-47bde8ae****</para>
            /// </summary>
            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            /// <summary>
            /// <para>编排模板创建时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25T16:56:33+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>编排模板更新时间。</para>
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
