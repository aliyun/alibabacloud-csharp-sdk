// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarClawChannelRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The channel configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;enabled&quot;: true,
        ///     &quot;dmPolicy&quot;: &quot;open&quot;,
        ///     &quot;allowFrom&quot;: [
        ///         &quot;*&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("ChannelConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ChannelConfig { get; set; }

        /// <summary>
        /// <para>The unique identifier of the channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feishu</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The npm package name of the channel plugin, including the version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@larksuite/<a href="mailto:openclaw-lark@2026.4.7">openclaw-lark@2026.4.7</a></para>
        /// </summary>
        [NameInMap("NpmPackage")]
        [Validation(Required=false)]
        public string NpmPackage { get; set; }

        /// <summary>
        /// <para>The channel plugin name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openclaw-lark</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the gateway after creation. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

    }

}
