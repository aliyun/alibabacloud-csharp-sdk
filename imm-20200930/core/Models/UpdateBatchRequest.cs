// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class UpdateBatchRequest : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<UpdateBatchRequestActions> Actions { get; set; }
        public class UpdateBatchRequestActions : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<string> Parameters { get; set; }

        }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public Input Input { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
