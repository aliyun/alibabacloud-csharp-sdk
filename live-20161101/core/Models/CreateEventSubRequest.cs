// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateEventSubRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application to subscribe to. You can view your application IDs by navigating to <b>ApsaraVideo Live &gt; Live+ &gt; ApsaraVideo Real-time Communication &gt; Application Management</b>. If no application exists, create one by clicking [Create Application].</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9qb1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The callback URL. For the callback content, see the callback content examples below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.com/callback</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The ID of the channel to subscribe to. You can call the <a href="https://help.aliyun.com/document_detail/2848210.html">ListEventSub</a> operation to query the subscribed channel IDs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the Users.N parameter is not empty, this parameter is required.</description></item>
        /// <item><description>If ChannelId is set to \* or left empty, all channels are subscribed. Each AppId allows only one all-channel subscription.</description></item>
        /// <item><description>Each AppId allows a maximum of 20 subscriptions at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123333</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The subscription events.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// <para>The users whose messages you want to subscribe to. If this parameter is empty, all users in the channel (including streamers and viewers) are subscribed. Format:</para>
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
