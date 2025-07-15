// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateEventSubRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9qb1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The callback URL. For more information about the content of the messages that are sent to the callback URL, see the Callback section in this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.com/callback</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The channel ID. You can call the <a href="https://help.aliyun.com/document_detail/2628135.html">ListEventSub</a> operation to query the channel ID.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if you specify the Users.N parameter.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to \* or do not specify this parameter, all channels are subscribed to.</para>
        /// </description></item>
        /// <item><description><para>Each application ID allows only one all-channel subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123333</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>Subscribe to events.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// <para>The user whose events you want to subscribe to. If you leave this parameter empty, the events of all users in the channel are subscribed to, including the events of the streamer and viewers. Specify this parameter in the following format:</para>
        /// <pre><c>Users.1=****
        /// Users.2=****
        /// ......
        /// </c></pre>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
