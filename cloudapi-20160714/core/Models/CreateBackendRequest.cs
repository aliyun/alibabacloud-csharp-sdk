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
        /// </summary>
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        /// <summary>
        /// The type of the backend service. Valid values: `HTTP, VPC, FC_EVENT, FC_HTTP, OSS, and MOCK`.
        /// </summary>
        [NameInMap("BackendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        /// <summary>
        /// Specifies whether to create a role associated with EventBridge.
        /// </summary>
        [NameInMap("CreateEventBridgeServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? CreateEventBridgeServiceLinkedRole { get; set; }

        /// <summary>
        /// The description of the backend service.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
