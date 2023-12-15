// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the plug-in.
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// The name of the plug-in.
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// The business type of the plug-in.
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The tag of objects that match the lifecycle rule. You can specify multiple tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribePluginsRequestTag> Tag { get; set; }
        public class DescribePluginsRequestTag : TeaModel {
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
