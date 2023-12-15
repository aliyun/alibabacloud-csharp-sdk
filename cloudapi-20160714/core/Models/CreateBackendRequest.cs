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

        [NameInMap("CreateSlr")]
        [Validation(Required=false)]
        public bool? CreateSlr { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateBackendRequestTag> Tag { get; set; }
        public class CreateBackendRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
