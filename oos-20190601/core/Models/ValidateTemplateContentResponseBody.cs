// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ValidateTemplateContentResponseBody : TeaModel {
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ValidateTemplateContentResponseBodyTasks> Tasks { get; set; }
        public class ValidateTemplateContentResponseBodyTasks : TeaModel {
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

    }

}
