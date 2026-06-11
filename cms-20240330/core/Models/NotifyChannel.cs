// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyChannel : TeaModel {
        /// <summary>
        /// <para>The type of the notification channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;DingTalk&quot;</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The list of enabled sub-channels.</para>
        /// </summary>
        [NameInMap("enabledSubChannels")]
        [Validation(Required=false)]
        public List<string> EnabledSubChannels { get; set; }

        /// <summary>
        /// <para>The list of receivers.</para>
        /// </summary>
        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<string> Receivers { get; set; }

    }

}
