// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateRunRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assistantId1</para>
        /// </summary>
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>你是一个聪明的小助理</para>
        /// </summary>
        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>assistantId</para>
        /// </summary>
        [NameInMap("originalAssistantId")]
        [Validation(Required=false)]
        public string OriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>threadId123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
