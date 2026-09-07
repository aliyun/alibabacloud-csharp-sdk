// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class RemoveKnowledgeTagsRequest : TeaModel {
        /// <summary>
        /// <para>The database cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp19aaaaaa****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The location of the knowledge base document.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/doc.pdf</para>
        /// </summary>
        [NameInMap("FileLocation")]
        [Validation(Required=false)]
        public string FileLocation { get; set; }

        /// <summary>
        /// <para>The JSON string of the tag array to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;tag_key&quot;:&quot;biz.scene&quot;,&quot;tag_value&quot;:&quot;test&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
