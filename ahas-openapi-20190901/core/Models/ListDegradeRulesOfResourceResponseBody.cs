// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ListDegradeRulesOfResourceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDegradeRulesOfResourceResponseBodyData Data { get; set; }
        public class ListDegradeRulesOfResourceResponseBodyData : TeaModel {
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public int? PageIndex { get; set; }
            [NameInMap("Datas")]
            [Validation(Required=false)]
            public List<ListDegradeRulesOfResourceResponseBodyDataDatas> Datas { get; set; }
            public class ListDegradeRulesOfResourceResponseBodyDataDatas : TeaModel {
                public int? SlowRtMs { get; set; }
                public int? HalfOpenRecoveryStepNum { get; set; }
                public string Namespace { get; set; }
                public int? StatDurationMs { get; set; }
                public long? RuleId { get; set; }
                public int? Strategy { get; set; }
                public string Resource { get; set; }
                public string AppName { get; set; }
                public int? HalfOpenBaseAmountPerStep { get; set; }
                public int? RecoveryTimeoutMs { get; set; }
                public int? MinRequestAmount { get; set; }
                public float? Threshold { get; set; }
                public bool? Enable { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
