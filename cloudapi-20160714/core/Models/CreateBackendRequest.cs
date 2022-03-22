// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateBackendRequest : TeaModel {
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        [NameInMap("BackendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        [NameInMap("CreateEventBridgeServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? CreateEventBridgeServiceLinkedRole { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
