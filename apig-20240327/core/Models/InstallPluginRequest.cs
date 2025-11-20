// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InstallPluginRequest : TeaModel {
        /// <summary>
        /// <para>The list of gateway IDs.</para>
        /// </summary>
        [NameInMap("gatewayIds")]
        [Validation(Required=false)]
        public List<string> GatewayIds { get; set; }

        /// <summary>
        /// <para>The plug-in type ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pls-csqmjndlhtguk0loef21</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

    }

}
