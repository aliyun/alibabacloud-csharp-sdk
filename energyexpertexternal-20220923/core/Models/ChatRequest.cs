// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <para>Q&amp;A content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>How to access knowledge base Q&amp;A documents.</para>
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Q&amp;A session ID.</description></item>
        /// <item><description>Historical sessions can be retrieved through GetSessionList.</description></item>
        /// <item><description>A new session can also be created via CreateChatSession.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bfce2248-1546-4298-8bcf-70ac26e69646</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
