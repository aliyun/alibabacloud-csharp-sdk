// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListEventSubResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE050E24-BE9B-1E79-BB30-7EA0BBAE7F08</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The events.</para>
        /// </summary>
        [NameInMap("Subscribers")]
        [Validation(Required=false)]
        public List<ListEventSubResponseBodySubscribers> Subscribers { get; set; }
        public class ListEventSubResponseBodySubscribers : TeaModel {
            /// <summary>
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.com/callback</para>
            /// </summary>
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// <para>The ID of the channel to which you subscribe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testmodify</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The time when the subscription was created. The time is displayed in UTC+8. Format: yyyy-MM-dd hh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-18 10:14:49</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The type of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ChannelEvent: channel event. For example, the channel is opened or closed.</description></item>
            /// <item><description>UserEvent: user event. For example, a user joins or leaves the channel.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<string> Events { get; set; }

            /// <summary>
            /// <para>The time when the subscription was modified. The time is displayed in UTC+8. Format: yyyy-MM-dd hh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-18 10:14:49</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The role of the user whose events are returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: streamer</description></item>
            /// <item><description>2: viewer</description></item>
            /// </list>
            /// <para>An empty value or a value other than 1 and 2 indicates that events of all users in the channel are returned.</para>
            /// <remarks>
            /// <para> This parameter is deprecated. When you create a subscription, this parameter is no longer supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            [Obsolete]
            public int? Roles { get; set; }

            /// <summary>
            /// <para>The ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09be0d2254cb5a89f4cbd86403ec****</para>
            /// </summary>
            [NameInMap("SubId")]
            [Validation(Required=false)]
            public string SubId { get; set; }

            /// <summary>
            /// <para>The user whose events are returned. We recommend that you use either this parameter or Roles.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<string> Users { get; set; }

        }

    }

}
