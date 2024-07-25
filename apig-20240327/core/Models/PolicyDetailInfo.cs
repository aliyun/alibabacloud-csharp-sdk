// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PolicyDetailInfo : TeaModel {
        [NameInMap("classId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
