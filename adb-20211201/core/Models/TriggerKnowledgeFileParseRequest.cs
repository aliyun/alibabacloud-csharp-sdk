// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class TriggerKnowledgeFileParseRequest : TeaModel {
        /// <summary>
        /// <para>The ADB instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp19aaaaaa****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base file. You must specify either this parameter or FileLocation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The path to a single file in the knowledge base. You must specify either this parameter or FileId. You cannot specify a directory. The path must uniquely identify an existing file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/doc.pdf</para>
        /// </summary>
        [NameInMap("FileLocation")]
        [Validation(Required=false)]
        public string FileLocation { get; set; }

    }

}
