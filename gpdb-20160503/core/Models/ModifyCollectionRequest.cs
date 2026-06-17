// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The collection name.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> operation to list all collections.</para>
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
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query details for all AnalyticDB for PostgreSQL instances in a region, including their instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>A JSON string that specifies the operations to add or modify metadata fields. For the required format, see the example.</para>
        /// <para>Use this parameter to add new metadata fields, rename existing metadata fields, or perform implicit data type conversion on existing fields.</para>
        /// <para>Details:</para>
        /// <para>To add a new metadata field, set <c>operations[*].operator = add</c>. Then, use <c>operations[*].newMetaName</c> to specify the field\&quot;s name, <c>operations[*].newMetaType</c> for its data type, and <c>operations[*].fullTextRetrieval</c> to enable full-text retrieval for it.</para>
        /// <para>To modify an existing metadata field, set <c>operations[*].operator = replace</c>. You must specify the current field name in <c>operations[*].oldMetaName</c>. To rename the field, provide the new name in <c>operations[*].newMetaName</c>. To change its data type, provide the new type in <c>operations[*].newMetaType</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For a list of supported data types, see <a href="https://help.aliyun.com/document_detail/424383.html">Data types</a>. The money data type is not supported.</para>
        /// </description></item>
        /// <item><description><para>Full-text retrieval can be enabled for a field only during an <c>add</c> operation, not a <c>replace</c> operation.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>The field names <c>id</c>, <c>vector</c>, <c>to_tsvector</c>, and <c>source</c> are reserved.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;operations&quot;:[
        /// {&quot;operator&quot;:&quot;add&quot;,&quot;newMetaType&quot;:&quot;int&quot;,&quot;newMetaName&quot;:&quot;ext1&quot;,&quot;fullTextRetrieval&quot;:true},
        /// {&quot;operator&quot;:&quot;replace&quot;,&quot;oldMetaName&quot;:&quot;ext2&quot;,&quot;newMetaName&quot;:&quot;ext3&quot;},
        /// {&quot;operator&quot;:&quot;replace&quot;,&quot;newMetaType&quot;:&quot;bigint&quot;,&quot;oldMetaName&quot;:&quot;ext4&quot;},
        /// {&quot;operator&quot;:&quot;replace&quot;,&quot;newMetaType&quot;:&quot;int&quot;,&quot;oldMetaName&quot;:&quot;ext5&quot;,&quot;newMetaName&quot;:&quot;ext6&quot;}
        /// ]}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <para>The namespace. The default value is <c>public</c>.</para>
        /// <remarks>
        /// <para>You can call the CreateNamespace operation to create a namespace and the ListNamespaces operation to list existing namespaces.</para>
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
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains multiple database instances. You must specify either this parameter or <c>DBInstanceId</c>. If you specify both, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
