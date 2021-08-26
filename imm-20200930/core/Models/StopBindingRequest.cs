// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class StopBindingRequest : TeaModel {
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
