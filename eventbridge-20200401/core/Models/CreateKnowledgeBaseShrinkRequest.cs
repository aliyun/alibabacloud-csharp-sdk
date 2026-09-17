// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateKnowledgeBaseShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The EventHouse catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies the knowledge base. This parameter cannot be modified after the knowledge base is created. System catalogs cannot be bound.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. The default chunking strategy for the knowledge base. This strategy applies only to documents uploaded after the configuration is set. If this parameter is not specified, the system default chunking strategy is used.</para>
        /// </summary>
        [NameInMap("ChunkConfiguration")]
        [Validation(Required=false)]
        public string ChunkConfigurationShrink { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product documentation knowledge base</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Optional. The vector dimensions. The value is validated against the embedding model: text-embedding-v3 supports 64, 128, 256, 512, 768, and 1024. text-embedding-v4 supports 64, 128, 256, 512, 768, 1024, 1536, and 2048. qwen3.7-text-embedding supports 256, 512, 768, 1024, 1536, 2048, and 2560. qwen3.7-text-embedding-flash supports 256, 512, 768, and 1024. Default value: 1024 (the default dimension of the model). This parameter cannot be modified after the knowledge base is created. Even if the dimensions are the same, you must rebuild the knowledge base when switching models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("EmbeddingDimension")]
        [Validation(Required=false)]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// <para>Optional. The embedding model used for vectorization. This parameter cannot be modified after the knowledge base is created. Valid values: text-embedding-v3, text-embedding-v4, qwen3.7-text-embedding, and qwen3.7-text-embedding-flash. Only Bailian Tongyi models are supported. Third-party models are not supported. Default value: text-embedding-v4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-docs</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>Declares the metadata fields of the knowledge base. When you upload documents, the metadata can contain only the fields declared here. This parameter cannot be modified after the knowledge base is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;department&quot;,&quot;Type&quot;:&quot;STRING&quot;}]</para>
        /// </summary>
        [NameInMap("MetadataSchema")]
        [Validation(Required=false)]
        public string MetadataSchemaShrink { get; set; }

        /// <summary>
        /// <para>The EventHouse namespace to which the knowledge base belongs. The namespace must belong to the specified catalog. This parameter, together with Catalog and KnowledgeBaseName, uniquely identifies the knowledge base. This parameter cannot be modified after the knowledge base is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Optional. The default search configuration at the knowledge base level. This configuration takes effect when the corresponding parameters are not specified in search requests. You can modify this configuration after creation by calling UpdateKnowledgeBase.</para>
        /// </summary>
        [NameInMap("SearchConfiguration")]
        [Validation(Required=false)]
        public string SearchConfigurationShrink { get; set; }

    }

}
