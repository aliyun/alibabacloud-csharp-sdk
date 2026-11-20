// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ConversationUpdateCmd : TeaModel {
        /// <summary>
        /// <para>The conversation data in JSON format, containing message records for each model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;messages&quot;:[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;Hello&quot;}]}</para>
        /// </summary>
        [NameInMap("chatData")]
        [Validation(Required=false)]
        public string ChatData { get; set; }

        /// <summary>
        /// <para>The number of messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("messageCount")]
        [Validation(Required=false)]
        public int? MessageCount { get; set; }

        /// <summary>
        /// <para>The list of model IDs as a JSON array string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1,2,3]</para>
        /// </summary>
        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>The conversation title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My conversation</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
