// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class Entity : TeaModel {
        [NameInMap("EntityContent")]
        [Validation(Required=false)]
        public Dictionary<string, object> EntityContent { get; set; }

        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
