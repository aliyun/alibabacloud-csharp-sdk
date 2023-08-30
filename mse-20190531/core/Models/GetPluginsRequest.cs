// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginsRequest : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Specifies whether to enable the plug-in.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// The name of the plug-in.
        /// </summary>
        [NameInMap("EnableOnly")]
        [Validation(Required=false)]
        public bool? EnableOnly { get; set; }

        /// <summary>
        /// The type of the plug-in. Valid values:
        /// 
        /// *   0: custom
        /// *   1: permission authorization
        /// *   2: security protection
        /// *   3: transmission protocol
        /// *   4: traffic control
        /// *   5: traffic observation
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// zh: Chinese en: English
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
