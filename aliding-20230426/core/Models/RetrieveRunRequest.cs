// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RetrieveRunRequest : TeaModel {
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
        /// <para>assistantId</para>
        /// </summary>
        [NameInMap("originalAssistantId")]
        [Validation(Required=false)]
        public string OriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>runId123</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

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
