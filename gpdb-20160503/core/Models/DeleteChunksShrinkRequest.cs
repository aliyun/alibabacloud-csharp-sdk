// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DeleteChunksShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of chunk IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChunkIds")]
        [Validation(Required=false)]
        public string ChunkIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the document collection.</para>
        /// <remarks>
        /// <para>You create this document collection by calling the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. To view existing document collections, call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testcollection</para>
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to view details for all AnalyticDB for PostgreSQL instances in a specific region, including their instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the namespace. The default value is public.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view a list of namespaces.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The password for the namespace.</para>
        /// <remarks>
        /// <para>This password is set when you call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
