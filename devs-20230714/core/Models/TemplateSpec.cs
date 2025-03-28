// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateSpec : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAP</para>
        /// </summary>
        [NameInMap("author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Apache-1.0</para>
        /// </summary>
        [NameInMap("license")]
        [Validation(Required=false)]
        public string License { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo-package</para>
        /// </summary>
        [NameInMap("packageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

        [NameInMap("registryToken")]
        [Validation(Required=false)]
        public string RegistryToken { get; set; }

        [NameInMap("services")]
        [Validation(Required=false)]
        public Dictionary<string, TemplateServiceConfig> Services { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public TemplateSpecSource Source { get; set; }
        public class TemplateSpecSource : TeaModel {
            [NameInMap("repository")]
            [Validation(Required=false)]
            public RepositorySourceConfig Repository { get; set; }

        }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, TemplateParameterSchema> Variables { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
