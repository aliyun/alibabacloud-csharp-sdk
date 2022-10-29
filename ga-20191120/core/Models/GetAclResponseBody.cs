// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetAclResponseBody : TeaModel {
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyAclEntries> AclEntries { get; set; }
        public class GetAclResponseBodyAclEntries : TeaModel {
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            [NameInMap("EntryDescription")]
            [Validation(Required=false)]
            public string EntryDescription { get; set; }

        }

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        [NameInMap("RelatedListeners")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyRelatedListeners> RelatedListeners { get; set; }
        public class GetAclResponseBodyRelatedListeners : TeaModel {
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
