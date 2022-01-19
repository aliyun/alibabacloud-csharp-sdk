// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Jarvis_public20180621.Models
{
    public class DescribeAttackEventResponseBody : TeaModel {
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<DescribeAttackEventResponseBodyEventList> EventList { get; set; }
        public class DescribeAttackEventResponseBodyEventList : TeaModel {
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public string AttackType { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtCreateStamp")]
            [Validation(Required=false)]
            public int? GmtCreateStamp { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("VmIp")]
            [Validation(Required=false)]
            public string VmIp { get; set; }

        }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
