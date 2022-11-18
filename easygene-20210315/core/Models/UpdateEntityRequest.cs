// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class UpdateEntityRequest : TeaModel {
        [NameInMap("EntityItems")]
        [Validation(Required=false)]
        public List<UpdateEntityRequestEntityItems> EntityItems { get; set; }
        public class UpdateEntityRequestEntityItems : TeaModel {
            [NameInMap("EntityData")]
            [Validation(Required=false)]
            public Dictionary<string, string> EntityData { get; set; }

            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

        }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
