// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddMetaCollectionEntityRequest : TeaModel {
        [NameInMap("CollectionQualifiedName")]
        [Validation(Required=false)]
        public string CollectionQualifiedName { get; set; }

        [NameInMap("EntityQualifiedName")]
        [Validation(Required=false)]
        public string EntityQualifiedName { get; set; }

    }

}
