// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreatePluginConfigShrinkRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public long? PluginId { get; set; }

        [NameInMap("ResourceIdList")]
        [Validation(Required=false)]
        public string ResourceIdListShrink { get; set; }

    }

}
