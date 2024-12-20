// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpsertCollectionDataAsyncAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the collection.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> operation to query a list of collections.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The Internet-accessible vector data file URL.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The file content must be in the JSONL format. Each line consists of a list of JSON data, which specifies a set of vector data.</para>
        /// </description></item>
        /// <item><description><para>Data format of each line: <c>{String Id; Map&lt;String, Object&gt; Metadata; List&lt;Double&gt; Vector}</c>. Example: <c>{&quot;Id&quot;:&quot;myid&quot;, &quot;Metadata&quot;: {&quot;my_meta_key&quot;: &quot;my_meta_value&quot;}, &quot;Vector&quot;: [1.234, -0.123]}</c>.</para>
        /// </description></item>
        /// <item><description><para>We recommend that you use SDKs to call this operation. SDKs encapsulate the UpsertCollectionDataAsyncAdvance method to upload on-premises files as data sources.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xx/vectors.jsonl">https://xx/vectors.jsonl</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <para>The name of the namespace. Default value: public.</para>
        /// <remarks>
        /// <para> You can call the CreateNamespace operation to create a namespace and call the ListNamespaces operation to query a list of namespaces.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The password of the namespace.</para>
        /// <remarks>
        /// <para> The value of this parameter is specified when you call the CreateNamespace operation.</para>
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
        /// <para>The ID of the Workspace composed of multiple database instances. This parameter and the DBInstanceId parameter cannot both be empty. When both are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
