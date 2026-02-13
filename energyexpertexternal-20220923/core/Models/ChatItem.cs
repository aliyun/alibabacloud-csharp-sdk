// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatItem : TeaModel {
        /// <summary>
        /// <para>The content of the answer to the question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No related content found.</para>
        /// </summary>
        [NameInMap("answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>Q&amp;A time, in milliseconds timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1747280158000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Folder selected for the Q&amp;A.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7708fddb-21dc-4403-a4ea-5b94eccce4c3</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>Name of the folder selected for the Q&amp;A.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deafult folder</para>
        /// </summary>
        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// <para>Question content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How to use the knowledge base.</para>
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>List of files related to the Q&amp;A.</description></item>
        /// <item><description>If streaming question answering is used, only the first shard contains data.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("refDocList")]
        [Validation(Required=false)]
        public List<ChatRefDocItem> RefDocList { get; set; }

    }

}
