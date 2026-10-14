// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class AddKnowledgeFileRequest : TeaModel {
        /// <summary>
        /// <para>The AnalyticDB for MySQL cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp19aaaaaa****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The file location. Only OSS paths are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket_name/file/path</para>
        /// </summary>
        [NameInMap("FileLocation")]
        [Validation(Required=false)]
        public string FileLocation { get; set; }

        /// <summary>
        /// <para>The file type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>Specifies whether the path is a folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDir")]
        [Validation(Required=false)]
        public bool? IsDir { get; set; }

        /// <summary>
        /// <para>The credibility or weight of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The file tags in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;game&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The user who uploads the knowledge base file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("UploadUser")]
        [Validation(Required=false)]
        public string UploadUser { get; set; }

    }

}
