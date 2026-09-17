// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListDocumentsRequest : TeaModel {
        /// <summary>
        /// <para>The data catalog to which the knowledge base belongs. This parameter, together with Namespace and KnowledgeBaseName, uniquely identifies a knowledge base. You can call ListCatalogs to obtain this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Optional. Filters documents by file name prefix (prefix match, with the same semantics as the NamePrefix parameter of ListEventStreamings). If this parameter is not specified or is set to an empty string, no filtering is applied. Maximum length: 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AfterSalesPolicy</para>
        /// </summary>
        [NameInMap("FileNamePrefix")]
        [Validation(Required=false)]
        public string FileNamePrefix { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. The name is unique within a namespace and is determined at creation time. It cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-knowledge-base</para>
        /// </summary>
        [NameInMap("KnowledgeBaseName")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page. If this parameter is not specified or is set to 0, the default value of 20 is used. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The namespace to which the knowledge base belongs. The namespace must belong to the specified data catalog. This parameter, together with Catalog and KnowledgeBaseName, uniquely identifies a knowledge base. You can call ListNamespaces to obtain this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Not required for the first query. For subsequent queries, use the NextToken value returned in the previous response. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca1eb85f5d99c7d6a97e6****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Optional. Filters documents by exact status match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPLOADING: uploading</description></item>
        /// <item><description>PENDING: pending processing</description></item>
        /// <item><description>PROCESSING: processing</description></item>
        /// <item><description>COMPLETED: completed</description></item>
        /// <item><description>FAILED: failed</description></item>
        /// <item><description>DELETING: deleting</description></item>
        /// </list>
        /// <para>If this parameter is not specified, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
