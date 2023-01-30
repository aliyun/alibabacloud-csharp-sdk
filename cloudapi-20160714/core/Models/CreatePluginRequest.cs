// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreatePluginRequest : TeaModel {
        /// <summary>
        /// The description of the plug-in. The description can contain a maximum of 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The plug-in definition statement, which can be in JSON or YAML format.
        /// </summary>
        [NameInMap("PluginData")]
        [Validation(Required=false)]
        public string PluginData { get; set; }

        /// <summary>
        /// The name of the plug-in. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (\_). However, it cannot start with an underscore.
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// The type of the plug-in. Valid values:
        /// 
        /// *   **ipControl: IP address-based access control**
        /// *   **trafficControl: throttling**
        /// *   **backendSignature: backend signature**
        /// *   **jwtAuth** :JWT (OpenId Connect) authentication
        /// *   **cors** :cross-origin resource sharing (CORS)
        /// *   **caching**
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The tag of objects that match the rule. You can specify multiple tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePluginRequestTag> Tag { get; set; }
        public class CreatePluginRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// 
            /// N can be an integer from 1 to 20.``
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// 
            /// N can be an integer from 1 to 20.``
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
