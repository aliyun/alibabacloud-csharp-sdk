// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianChatBot20241105.Models
{
    public class SseChatRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-dDmF3jcdVf</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TIMEOUT</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>uid129312098593</para>
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15e04f27-acd7-489d-872f-1d68f7535e33</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public string VendorParam { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-g7jspxljq8k909h3</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
