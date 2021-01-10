// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutAdminuserroleRequest : TeaModel {
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("BahamutTenant")]
        [Validation(Required=false)]
        public string BahamutTenant { get; set; }

        [NameInMap("Created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public long? LastModified { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
