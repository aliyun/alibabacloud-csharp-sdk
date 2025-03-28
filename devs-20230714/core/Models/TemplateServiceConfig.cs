// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateServiceConfig : TeaModel {
        [NameInMap("artifact")]
        [Validation(Required=false)]
        public ArtifactMeta Artifact { get; set; }

        [NameInMap("build")]
        [Validation(Required=false)]
        public BuildConfig Build { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:fc3@1.0.0">fc3@1.0.0</a></para>
        /// </summary>
        [NameInMap("component")]
        [Validation(Required=false)]
        public string Component { get; set; }

        [NameInMap("props")]
        [Validation(Required=false)]
        public Dictionary<string, object> Props { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public SourceConfig Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Function</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, TemplateParameterSchema> Variables { get; set; }

    }

}
