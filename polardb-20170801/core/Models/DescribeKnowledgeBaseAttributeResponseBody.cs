// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBaseAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of AI applications bound to the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BindingAppCount")]
        [Validation(Required=false)]
        public int? BindingAppCount { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-14T05:58:42Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The unique identifier of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-xxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The type of the knowledge base. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC</description></item>
        /// <item><description>PERSONAL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("KnowledgeBaseType")]
        [Validation(Required=false)]
        public string KnowledgeBaseType { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pks-xxxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeSpaceId")]
        [Validation(Required=false)]
        public string KnowledgeSpaceId { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The search mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>balanced (default)</description></item>
        /// <item><description>precise</description></item>
        /// <item><description>semantic</description></item>
        /// <item><description>knn</description></item>
        /// <item><description>rrf</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>balanced</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The number of shards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The status of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Activation</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of documents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalDocs")]
        [Validation(Required=false)]
        public int? TotalDocs { get; set; }

        /// <summary>
        /// <para>The total size in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>318881</para>
        /// </summary>
        [NameInMap("TotalSizeBytes")]
        [Validation(Required=false)]
        public long? TotalSizeBytes { get; set; }

    }

}
