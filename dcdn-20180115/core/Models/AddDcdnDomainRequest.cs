/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class AddDcdnDomainRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
