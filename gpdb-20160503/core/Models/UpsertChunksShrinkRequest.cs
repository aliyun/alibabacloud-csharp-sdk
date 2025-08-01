// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpsertChunksShrinkRequest : TeaModel {
        [NameInMap("AllowInsertWithFilter")]
        [Validation(Required=false)]
        public bool? AllowInsertWithFilter { get; set; }

        /// <summary>
        /// <para>Document collection name.</para>
        /// <remarks>
        /// <para>Created by the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> API. You can use the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> API to view the already created document collections.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> API to view details of all AnalyticDB PostgreSQL instances in the target region, including the instance ID.</para>
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
        /// <para>File name.</para>
        /// <remarks>
        /// <para>If a file name is specified and not empty, it will overwrite the data for this file name; if empty, the chunks data will be appended directly to the document collection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mydoc.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>Namespace, default is public.</para>
        /// <remarks>
        /// <para>You can create it using the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> API and view the list using the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> API.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Password corresponding to the namespace.</para>
        /// <remarks>
        /// <para>This value is specified by the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> API.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Region ID where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ShouldReplaceFile")]
        [Validation(Required=false)]
        public bool? ShouldReplaceFile { get; set; }

        /// <summary>
        /// <para>List of split documents.</para>
        /// </summary>
        [NameInMap("TextChunks")]
        [Validation(Required=false)]
        public string TextChunksShrink { get; set; }

    }

}
