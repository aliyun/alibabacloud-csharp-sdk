// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSLARulesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SLARuleList")]
        [Validation(Required=false)]
        public ListSLARulesResponseBodySLARuleList SLARuleList { get; set; }
        public class ListSLARulesResponseBodySLARuleList : TeaModel {
            [NameInMap("SLARule")]
            [Validation(Required=false)]
            public List<ListSLARulesResponseBodySLARuleListSLARule> SLARule { get; set; }
            public class ListSLARulesResponseBodySLARuleListSLARule : TeaModel {
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IntervalMinutes")]
                [Validation(Required=false)]
                public int? IntervalMinutes { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public int? RuleType { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
