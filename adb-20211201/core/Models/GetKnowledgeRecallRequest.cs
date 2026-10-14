// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetKnowledgeRecallRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp19aaaaaa****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The array of images to retrieve during image retrieval. Currently, only one image is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[     {       &quot;base64&quot;: &quot;/9j/4AAQSkZJRgABAQ...&quot;,       &quot;mime_type&quot;: &quot;image/jpeg&quot;     }   ]</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        /// <summary>
        /// <para>The file path prefix. Only files that match the path prefix are retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucketName/path/prefix/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The question for knowledge base retrieval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What are the reports for the clothing category this month?</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>The semantic rules. Currently, only &quot;all&quot; and &quot;&quot; are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("SemanticRules")]
        [Validation(Required=false)]
        public string SemanticRules { get; set; }

        /// <summary>
        /// <para>The list of tags in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;tag_key1&quot;: [&quot;tag_key1_value1&quot;, &quot;tag_key1_value2&quot;],   &quot;tag_key2&quot;: [&quot;tag_key2_value&quot;] }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The top K value for retrieving associated files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Topk")]
        [Validation(Required=false)]
        public int? Topk { get; set; }

        /// <summary>
        /// <para>The username. Only files that the user has permissions to access are retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_name1</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
