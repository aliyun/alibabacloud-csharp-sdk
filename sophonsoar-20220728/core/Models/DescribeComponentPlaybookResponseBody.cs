// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentPlaybookResponseBody : TeaModel {
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<DescribeComponentPlaybookResponseBodyPlaybooks> Playbooks { get; set; }
        public class DescribeComponentPlaybookResponseBodyPlaybooks : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
