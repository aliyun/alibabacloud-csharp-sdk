// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateBackendRequest : TeaModel {
        /// <summary>
        /// The name of the backend service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        /// <summary>
        /// The type of the backend service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        /// <summary>
        /// Specifies to create a EventBridge service-linked role.
        /// </summary>
        [NameInMap("CreateEventBridgeServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? CreateEventBridgeServiceLinkedRole { get; set; }

        /// <summary>
        /// Specifies to create a service-linked role.
        /// </summary>
        [NameInMap("CreateSlr")]
        [Validation(Required=false)]
        public bool? CreateSlr { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The tag of objects that match the rule. You can specify multiple tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateBackendRequestTag> Tag { get; set; }
        public class CreateBackendRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
