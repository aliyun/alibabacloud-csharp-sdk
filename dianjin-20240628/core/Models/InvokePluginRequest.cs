// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class InvokePluginRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3mj87da7zr</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

    }

}
