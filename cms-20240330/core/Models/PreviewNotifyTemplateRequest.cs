// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PreviewNotifyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The rendering context data in a key-value pair structure. It serves as the data source to populate Go template placeholders in the template, such as {{.incident.title}}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;incident&quot;:{&quot;title&quot;:&quot;High CPU usage&quot;,&quot;severity&quot;:&quot;P1&quot;}}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The list of templates to be rendered. Each item contains a template identifier and the template content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;title&quot;,&quot;template&quot;:&quot;CloudMonitor alert: {{.incident.title}}&quot;},{&quot;key&quot;:&quot;content&quot;,&quot;template&quot;:&quot;&gt;- Severity: {{.incident.severity}}&quot;}]</para>
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public List<PreviewNotifyTemplateRequestTemplates> Templates { get; set; }
        public class PreviewNotifyTemplateRequestTemplates : TeaModel {
            /// <summary>
            /// <para>The template identifier. It is custom-defined by the frontend and returned as-is. Use semantic names such as title or content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The template content string in Go template syntax.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudMonitor alert: {{.incident.title}}</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

    }

}
