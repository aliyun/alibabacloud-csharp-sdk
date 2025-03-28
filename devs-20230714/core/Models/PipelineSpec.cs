// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineSpec : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public Context Context { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-pipeline-template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("templateSpec")]
        [Validation(Required=false)]
        public PipelineTemplateSpec TemplateSpec { get; set; }

    }

}
