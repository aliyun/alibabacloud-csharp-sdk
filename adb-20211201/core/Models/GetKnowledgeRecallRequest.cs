// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetKnowledgeRecallRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ADB MySQL cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp19aaaaaa****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The file path prefix. Only files that match the specified path prefix are recalled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucketName/path/prefix/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The question for knowledge base recall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What are the reports for the clothing category this month?</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

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
        /// <para>The top K associated files to recall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Topk")]
        [Validation(Required=false)]
        public int? Topk { get; set; }

        /// <summary>
        /// <para>The username. Only files that the specified user has permission to access are recalled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_name1</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
