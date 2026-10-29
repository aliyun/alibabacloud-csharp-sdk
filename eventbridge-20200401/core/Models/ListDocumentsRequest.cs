// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListDocumentsRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. This parameter, along with Namespace and KnowledgeBaseName, uniquely identifies the knowledge base. You can call ListCatalogs to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. Filters documents by file name prefix. The prefix matching semantics are the same as those of the NamePrefix parameter in ListEventStreamings. If this parameter is not specified or is left empty, no filtering is applied. The maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>After-sales policy</para>
        /// </summary>
        [NameInMap("FileNamePrefix")]
        [Validation(Required=false)]
        public string FileNamePrefix { get; set; }

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
        /// <para>The maximum number of results to return per page. If this parameter is not specified or is set to 0, the default value 20 is used. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. This parameter, along with Catalog and KnowledgeBaseName, uniquely identifies the knowledge base. You can call ListNamespaces to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The token for the next page. You do not need to specify this parameter for the first query. For subsequent queries, use the NextToken value returned in the previous response. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca1eb85f5d99c7d6a97e6****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Optional. Filters documents by exact document status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPLOADING: The document is being uploaded.</description></item>
        /// <item><description>PENDING: The document is pending processing.</description></item>
        /// <item><description>PROCESSING: The document is being processed.</description></item>
        /// <item><description>COMPLETED: The document processing is completed.</description></item>
        /// <item><description>FAILED: The document processing failed.</description></item>
        /// <item><description>DELETING: The document is being deleted.
        /// If this parameter is not specified, no filtering is applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
