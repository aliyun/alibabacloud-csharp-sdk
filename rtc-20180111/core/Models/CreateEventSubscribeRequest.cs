// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateEventSubscribeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the subscribed application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9qb1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The callback URL. For information about the callback content, see the following callback content example.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.com/callback</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The ID of the subscribed channel.</para>
        /// <remarks>
        /// <para>This parameter is required if the Users.N parameter is not empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123333</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The idempotence identifier used by the client to create the subscription.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The subscribed events.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChannelEvent</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable callback authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables callback authentication.</description></item>
        /// <item><description><b>fasle</b> (default): disables callback authentication.</description></item>
        /// </list>
        /// <para>For more information, see the following callback authentication description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedCallbackAuth")]
        [Validation(Required=false)]
        public bool? NeedCallbackAuth { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The user role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: subscribes to host messages in the channel.</description></item>
        /// <item><description><b>2</b>: subscribes to audience messages in the channel.</description></item>
        /// <item><description><b>Empty or other values</b>: subscribes to messages from all roles in the channel without role filtering.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public long? Role { get; set; }

        /// <summary>
        /// <para>The subscribed users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
