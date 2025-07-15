// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtcMPUEventSubRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <remarks>
        /// <para> The ID can be up to 64 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// <remarks>
        /// <para> You can use headers such as HTTP and HTTPS in callback URLs. The URL can be up to 2,083 characters and contain letters, digits, and the following special characters: - _ ? % = # . / +</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.com/callback</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The ID of the channel to which you want to send mixed-stream relay event callbacks. Separate multiple channel IDs with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you leave this parameter empty, you are subscribed to all mixed-stream relay events submitted in the application.</para>
        /// </description></item>
        /// <item><description><para>You cannot specify duplicate channel IDs. You can specify up to 20 channel IDs in each call.</para>
        /// </description></item>
        /// <item><description><para>The ID can be up to 64 characters in length and contain letters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yourChannelIds</para>
        /// </summary>
        [NameInMap("ChannelIds")]
        [Validation(Required=false)]
        public string ChannelIds { get; set; }

    }

}
