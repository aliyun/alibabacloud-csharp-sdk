// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetDocumentDownloadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies the knowledge base. You can call ListCatalogs to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The ID of the document.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc-bp1xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name must be unique within the namespace. It is specified upon creation and cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. This parameter, together with Catalog and KnowledgeBaseName, uniquely identifies the knowledge base. You can call ListNamespaces to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The network type of the presigned URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Accessible over the Internet. This is the default value.</description></item>
        /// <item><description>INTERNAL: Accessible only over the internal network within the same Alibaba Cloud region. No Internet traffic fees are incurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

    }

}
