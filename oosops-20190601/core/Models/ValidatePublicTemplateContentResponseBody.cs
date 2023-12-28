// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ValidatePublicTemplateContentResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ValidatePublicTemplateContentResponseBodyTasks> Tasks { get; set; }
        public class ValidatePublicTemplateContentResponseBodyTasks : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
