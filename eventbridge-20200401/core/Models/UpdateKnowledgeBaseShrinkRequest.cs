// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateKnowledgeBaseShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. It is used together with Namespace and KnowledgeBaseName to locate the knowledge base. You can call ListCatalogs to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. Updates the default chunking strategy of the knowledge base. This update takes effect only for newly uploaded documents and does not re-chunk existing documents. If this parameter is not specified, the strategy is not modified.</para>
        /// </summary>
        [NameInMap("ChunkConfiguration")]
        [Validation(Required=false)]
        public string ChunkConfigurationShrink { get; set; }

        /// <summary>
        /// <para>Updates the description of the knowledge base. If this parameter is not specified, the description is not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product documentation knowledge base</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the namespace. It is specified during creation and cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. It is used together with Catalog and KnowledgeBaseName to locate the knowledge base. You can call ListNamespaces to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Optional. Updates the default search configuration at the knowledge base level. The update takes effect immediately for subsequent search requests. If this parameter is not specified, the configuration is not modified.</para>
        /// </summary>
        [NameInMap("SearchConfiguration")]
        [Validation(Required=false)]
        public string SearchConfigurationShrink { get; set; }

    }

}
