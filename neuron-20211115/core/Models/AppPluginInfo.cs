// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class AppPluginInfo : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("appVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("appVersionId")]
        [Validation(Required=false)]
        public long? AppVersionId { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public MobiPluginConfig Config { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MULTIPLEMALL_CONSOLE_LAYOUT_APPSTORE</para>
        /// </summary>
        [NameInMap("pluginKey")]
        [Validation(Required=false)]
        public string PluginKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PAGE</para>
        /// </summary>
        [NameInMap("pluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MOBI</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
