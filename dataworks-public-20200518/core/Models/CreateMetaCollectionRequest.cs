// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateMetaCollectionRequest : TeaModel {
        [NameInMap("CollectionType")]
        [Validation(Required=false)]
        public string CollectionType { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ParentQualifiedName")]
        [Validation(Required=false)]
        public string ParentQualifiedName { get; set; }

    }

}
