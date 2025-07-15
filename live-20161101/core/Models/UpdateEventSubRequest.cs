// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateEventSubRequest : TeaModel {
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
        /// <para>The callback URL. For more information about the callback content, see CreateEventSub.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.com/callback</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The channel ID. You can call the <a href="https://help.aliyun.com/document_detail/2848210.html">ListEventSub</a> operation to query the channel ID.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if you specify the Users.N parameter.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to \* or do not specify this parameter, all channels are subscribed to.</para>
        /// </description></item>
        /// <item><description><para>You can create up to 20 subscriptions for each application ID.</para>
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
        /// <para>The type of the events to which you want to subscribe.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// <para>The subscription ID. You can obtain the ID from the response to the <a href="https://help.aliyun.com/document_detail/2848209.html">CreateEventSub</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad53276431c****</para>
        /// </summary>
        [NameInMap("SubscribeId")]
        [Validation(Required=false)]
        public string SubscribeId { get; set; }

        /// <summary>
        /// <para>The user whose events you want to subscribe to.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
