// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateChatSessionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the chat session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product consultation session</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of API products associated with the chat session.</para>
        /// </summary>
        [NameInMap("products")]
        [Validation(Required=false)]
        public List<string> Products { get; set; }

        /// <summary>
        /// <para>The conversation type of the session. Valid values: MODEL and AGENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MODEL</para>
        /// </summary>
        [NameInMap("talkType")]
        [Validation(Required=false)]
        public string TalkType { get; set; }

    }

}
