// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InstallPluginRequest : TeaModel {
        [NameInMap("gatewayIds")]
        [Validation(Required=false)]
        public List<string> GatewayIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pls-csqmjndlhtguk0loef21</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

    }

}
