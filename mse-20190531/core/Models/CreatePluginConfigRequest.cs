// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreatePluginConfigRequest : TeaModel {
        /// <summary>
        /// The language in which you want to display the results. Valid values: zh and en. zh indicates Chinese, which is the default value. en indicates English.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The plug-in configuration. The configuration content of the WebAssembly (Wasm) plug-in is in the YAML format. The configuration content of the Lua plug-in is Lua code.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The application scope of the plug-in. Valid values:
        /// 
        /// *   0: global
        /// *   1: route
        /// *   2: domain name
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        /// <summary>
        /// Indicates whether the plug-in is enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The gateway plug-in ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public long? PluginId { get; set; }

        /// <summary>
        /// The domain IDs or route IDs. They are distinguished based on ConfigLevel.
        /// </summary>
        [NameInMap("ResourceIdList")]
        [Validation(Required=false)]
        public List<long?> ResourceIdList { get; set; }

    }

}
