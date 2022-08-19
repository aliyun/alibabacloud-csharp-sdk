/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class AddEntriesToAclRequest : TeaModel {
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<AddEntriesToAclRequestAclEntries> AclEntries { get; set; }
        public class AddEntriesToAclRequestAclEntries : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
