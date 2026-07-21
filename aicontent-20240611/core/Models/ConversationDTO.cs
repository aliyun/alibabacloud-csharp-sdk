// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ConversationDTO : TeaModel {
        /// <summary>
        /// <para>A JSON-formatted string that represents the complete state of the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("chatData")]
        [Validation(Required=false)]
        public string ChatData { get; set; }

        /// <summary>
        /// <para>The status of the conversation, where 0 means enabled and any non-zero value means disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("deleteTag")]
        [Validation(Required=false)]
        public int? DeleteTag { get; set; }

        /// <summary>
        /// <para>The creation time of the conversation, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The modification time of the conversation, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The total number of messages in the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("messageCount")]
        [Validation(Required=false)]
        public int? MessageCount { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string that contains an array of model IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3]</para>
        /// </summary>
        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>The title of the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的对话</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
