// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpgradePolarClawChannelRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;enabled&quot;: true,
        ///     &quot;dmPolicy&quot;: &quot;open&quot;,
        ///     &quot;allowFrom&quot;: [
        ///         &quot;*&quot;,
        ///         &quot;ou_abc&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("ChannelConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ChannelConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feishu</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@larksuite/<a href="mailto:openclaw-feishu@2026.4.7">openclaw-feishu@2026.4.7</a></para>
        /// </summary>
        [NameInMap("NpmPackage")]
        [Validation(Required=false)]
        public string NpmPackage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>openclaw-feishu</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

    }

}
