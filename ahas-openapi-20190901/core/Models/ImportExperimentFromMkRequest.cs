// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ImportExperimentFromMkRequest : TeaModel {
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        [NameInMap("ImportUserId")]
        [Validation(Required=false)]
        public string ImportUserId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
