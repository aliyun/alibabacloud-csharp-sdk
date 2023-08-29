// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class Role : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("IsPredefined")]
        [Validation(Required=false)]
        public int? IsPredefined { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PrincipalArn")]
        [Validation(Required=false)]
        public string PrincipalArn { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<Principal> Users { get; set; }

    }

}
