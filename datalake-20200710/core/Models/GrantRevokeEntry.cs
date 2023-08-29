// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class GrantRevokeEntry : TeaModel {
        [NameInMap("Accesses")]
        [Validation(Required=false)]
        public List<string> Accesses { get; set; }

        [NameInMap("DelegateAccesses")]
        [Validation(Required=false)]
        public List<string> DelegateAccesses { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("MetaResource")]
        [Validation(Required=false)]
        public MetaResource MetaResource { get; set; }

        [NameInMap("Principal")]
        [Validation(Required=false)]
        public Principal Principal { get; set; }

    }

}
