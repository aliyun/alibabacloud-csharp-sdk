// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupStructResponseBody : TeaModel {
        [NameInMap("GroupFather")]
        [Validation(Required=false)]
        public int? GroupFather { get; set; }

        [NameInMap("GroupFlag")]
        [Validation(Required=false)]
        public int? GroupFlag { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupIndex")]
        [Validation(Required=false)]
        public int? GroupIndex { get; set; }

        [NameInMap("GroupLevel")]
        [Validation(Required=false)]
        public int? GroupLevel { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<string> Groups { get; set; }

        [NameInMap("MachineNum")]
        [Validation(Required=false)]
        public int? MachineNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
