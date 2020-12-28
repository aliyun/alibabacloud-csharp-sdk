// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ModifyHotParamRuleResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyHotParamRuleResponseBodyData Data { get; set; }
        public class ModifyHotParamRuleResponseBodyData : TeaModel {
            [NameInMap("ParamIdx")]
            [Validation(Required=false)]
            public int? ParamIdx { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("ParamFlowItemList")]
            [Validation(Required=false)]
            public List<ModifyHotParamRuleResponseBodyDataParamFlowItemList> ParamFlowItemList { get; set; }
            public class ModifyHotParamRuleResponseBodyDataParamFlowItemList : TeaModel {
                public string ItemValue { get; set; }
                public string ItemType { get; set; }
                public float? Threshold { get; set; }
            }
            [NameInMap("StatDurationSec")]
            [Validation(Required=false)]
            public long? StatDurationSec { get; set; }
            [NameInMap("BurstCount")]
            [Validation(Required=false)]
            public int? BurstCount { get; set; }
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("MaxQueueingTimeMs")]
            [Validation(Required=false)]
            public int? MaxQueueingTimeMs { get; set; }
            [NameInMap("ControlBehavior")]
            [Validation(Required=false)]
            public int? ControlBehavior { get; set; }
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public int? MetricType { get; set; }
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
