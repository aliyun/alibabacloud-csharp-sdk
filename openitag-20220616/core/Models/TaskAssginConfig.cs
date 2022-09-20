// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskAssginConfig : TeaModel {
        [NameInMap("AssignCount")]
        [Validation(Required=false)]
        public long? AssignCount { get; set; }

        [NameInMap("AssignField")]
        [Validation(Required=false)]
        public string AssignField { get; set; }

        [NameInMap("AssignSubTaskCount")]
        [Validation(Required=false)]
        public string AssignSubTaskCount { get; set; }

        [NameInMap("AssignType")]
        [Validation(Required=false)]
        public string AssignType { get; set; }

    }

}
