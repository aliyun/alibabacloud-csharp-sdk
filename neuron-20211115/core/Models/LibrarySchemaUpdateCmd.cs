// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class LibrarySchemaUpdateCmd : TeaModel {
        [NameInMap("artifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("gitGroup")]
        [Validation(Required=false)]
        public string GitGroup { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public long? LibraryId { get; set; }

    }

}
