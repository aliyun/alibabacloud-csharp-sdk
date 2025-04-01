// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class RenderServicesByTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;svc1&quot;:&quot;svc2&quot;}</para>
        /// </summary>
        [NameInMap("serviceNameChanges")]
        [Validation(Required=false)]
        public Dictionary<string, string> ServiceNameChanges { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start-springboot</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("variableValues")]
        [Validation(Required=false)]
        public TemplateVariableValueMap VariableValues { get; set; }

    }

}
