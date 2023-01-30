// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyApiGroupRequest : TeaModel {
        /// <summary>
        /// The API group description that you want to specify, which cannot exceed 180 characters. If this parameter is not specified, the group description is not modified.
        /// </summary>
        [NameInMap("BasePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// The data of custom configuration items.
        /// </summary>
        [NameInMap("CompatibleFlags")]
        [Validation(Required=false)]
        public string CompatibleFlags { get; set; }

        /// <summary>
        /// The list of associated tags. Separate multiple tags with commas (,).
        /// </summary>
        [NameInMap("CustomTraceConfig")]
        [Validation(Required=false)]
        public string CustomTraceConfig { get; set; }

        /// <summary>
        /// Specifies whether to pass headers.
        /// </summary>
        [NameInMap("CustomerConfigs")]
        [Validation(Required=false)]
        public string CustomerConfigs { get; set; }

        /// <summary>
        /// The RPC mode.
        /// </summary>
        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// The user log configuration.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The API group name must be globally unique. The name must be 4 to 50 characters in length. It must start with a letter and can contain letters, digits, and underscores (\_). If this parameter is not specified, the group name is not modified.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The root path of the API.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The default domain name.
        /// </summary>
        [NameInMap("PassthroughHeaders")]
        [Validation(Required=false)]
        public string PassthroughHeaders { get; set; }

        /// <summary>
        /// The object tags that match the lifecycle rule. You can specify multiple tags.
        /// </summary>
        [NameInMap("RpcPattern")]
        [Validation(Required=false)]
        public string RpcPattern { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The tags that are attached to the resources.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ModifyApiGroupRequestTag> Tag { get; set; }
        public class ModifyApiGroupRequestTag : TeaModel {
            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The custom trace configuration.
        /// </summary>
        [NameInMap("UserLogConfig")]
        [Validation(Required=false)]
        public string UserLogConfig { get; set; }

    }

}
