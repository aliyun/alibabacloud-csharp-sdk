// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PreviewNotifyTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;incident&quot;:{&quot;title&quot;:&quot;CPU使用率过高&quot;,&quot;severity&quot;:&quot;P1&quot;}}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>待渲染的模板列表，每项包含模板标识和模板内容</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;title&quot;,&quot;template&quot;:&quot;云监控报警: {{.incident.title}}&quot;},{&quot;key&quot;:&quot;content&quot;,&quot;template&quot;:&quot;&gt;- 级别: {{.incident.severity}}&quot;}]</para>
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public List<PreviewNotifyTemplateRequestTemplates> Templates { get; set; }
        public class PreviewNotifyTemplateRequestTemplates : TeaModel {
            /// <summary>
            /// <para>模板标识，前端自定义，原样返回。建议使用 title / content 等语义名称</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Go template 语法的模板内容字符串</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云监控报警: {{.incident.title}}</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

    }

}
