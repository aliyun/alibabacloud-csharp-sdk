// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRtcMPUEventSubRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application to subscribe to. You can view your application IDs by navigating to <b>ApsaraVideo Live &gt; Live+ &gt; ApsaraVideo Real-time Communication &gt; Application Management</b>. If no application exists, create one by clicking <b>Create Application</b>.</para>
        /// <remarks>
        /// <para>The application ID consists of uppercase and lowercase letters, digits, underscores, and hyphens (-), with a maximum of 64 characters.</para>
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
        /// <para>The callback URL. For the URL format, refer to the callback content specifications below.</para>
        /// <remarks>
        /// <para>The callback URL protocol must be HTTP or HTTPS. The URL can contain only the following characters: a-z, A-Z, 0-9, -, _, ?, %, =, #, ., /, and +. The URL cannot exceed 2083 characters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://****.com/callback</para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The channel IDs of the stream mixing tasks for which you want to receive callbacks. You can specify multiple channel IDs separated by commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, callbacks for all stream mixing and relaying tasks under the specified AppId are received by default.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When specifying multiple channel IDs, do not include duplicates. You can specify up to 20 channel IDs at a time.</description></item>
        /// <item><description>Each channel ID consists of uppercase and lowercase letters, digits, underscores, and hyphens (-), with a maximum of 64 characters.</description></item>
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
