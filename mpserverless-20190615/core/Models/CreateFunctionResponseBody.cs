// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class CreateFunctionResponseBody : TeaModel {
        [NameInMap("ModifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public CreateFunctionResponseBodySpec Spec { get; set; }
        public class CreateFunctionResponseBodySpec : TeaModel {
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public string Timeout { get; set; }
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }
        };

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
