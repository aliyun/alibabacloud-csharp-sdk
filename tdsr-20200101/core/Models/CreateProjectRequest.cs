// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class CreateProjectRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        [NameInMap("BusinessUserIdList")]
        [Validation(Required=false)]
        public string BusinessUserIdList { get; set; }

        [NameInMap("GatherUserIdList")]
        [Validation(Required=false)]
        public string GatherUserIdList { get; set; }

        [NameInMap("BuilderUserIdList")]
        [Validation(Required=false)]
        public string BuilderUserIdList { get; set; }

    }

}
