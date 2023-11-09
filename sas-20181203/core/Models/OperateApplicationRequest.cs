// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateApplicationRequest : TeaModel {
        [NameInMap("ContainerWebDefenseApplicationDTOS")]
        [Validation(Required=false)]
        public List<OperateApplicationRequestContainerWebDefenseApplicationDTOS> ContainerWebDefenseApplicationDTOS { get; set; }
        public class OperateApplicationRequestContainerWebDefenseApplicationDTOS : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
