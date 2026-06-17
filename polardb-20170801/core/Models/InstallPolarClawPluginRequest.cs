// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class InstallPolarClawPluginRequest : TeaModel {
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
        /// <para>The npm package name, including the version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@larksuite/<a href="mailto:openclaw-lark@2026.4.7">openclaw-lark@2026.4.7</a></para>
        /// </summary>
        [NameInMap("NpmPackage")]
        [Validation(Required=false)]
        public string NpmPackage { get; set; }

        /// <summary>
        /// <para>The plugin ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openclaw-lark</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the gateway after installation. Defaults to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

    }

}
