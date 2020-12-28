// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ListFlowRulesOfResourceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFlowRulesOfResourceResponseBodyData Data { get; set; }
        public class ListFlowRulesOfResourceResponseBodyData : TeaModel {
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public int? PageIndex { get; set; }
            [NameInMap("Datas")]
            [Validation(Required=false)]
            public List<ListFlowRulesOfResourceResponseBodyDataDatas> Datas { get; set; }
            public class ListFlowRulesOfResourceResponseBodyDataDatas : TeaModel {
                public string RefResource { get; set; }
                public int? ClusterFallbackThreshold { get; set; }
                public string Namespace { get; set; }
                public string LimitOrigin { get; set; }
                public int? StatDurationMs { get; set; }
                public int? ClusterThresholdType { get; set; }
                public long? RuleId { get; set; }
                public int? RelationStrategy { get; set; }
                public string AppName { get; set; }
                public string Resource { get; set; }
                public float? ClusterEstimatedMaxQps { get; set; }
                public int? ControlBehavior { get; set; }
                public int? MaxQueueingTimeMs { get; set; }
                public int? ClusterFallbackStrategy { get; set; }
                public int? WarmUpPeriodSec { get; set; }
                public bool? ClusterMode { get; set; }
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
