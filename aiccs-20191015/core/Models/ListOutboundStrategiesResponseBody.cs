// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListOutboundStrategiesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OutboundStrategies")]
        [Validation(Required=false)]
        public List<ListOutboundStrategiesResponseBodyOutboundStrategies> OutboundStrategies { get; set; }
        public class ListOutboundStrategiesResponseBodyOutboundStrategies : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SuccessRate")]
            [Validation(Required=false)]
            public int? SuccessRate { get; set; }

            [NameInMap("Process")]
            [Validation(Required=false)]
            public int? Process { get; set; }

            [NameInMap("GmtModifiedStr")]
            [Validation(Required=false)]
            public string GmtModifiedStr { get; set; }

            [NameInMap("OutboundNum")]
            [Validation(Required=false)]
            public string OutboundNum { get; set; }

            [NameInMap("OutboundStrategyName")]
            [Validation(Required=false)]
            public string OutboundStrategyName { get; set; }

            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public long? ModifierId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("OutboundStrategyId")]
            [Validation(Required=false)]
            public long? OutboundStrategyId { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            [NameInMap("RobotName")]
            [Validation(Required=false)]
            public string RobotName { get; set; }

            [NameInMap("ModifierName")]
            [Validation(Required=false)]
            public string ModifierName { get; set; }

            [NameInMap("ResourceAllocation")]
            [Validation(Required=false)]
            public int? ResourceAllocation { get; set; }

            [NameInMap("ExtAttr")]
            [Validation(Required=false)]
            public string ExtAttr { get; set; }

            [NameInMap("NumType")]
            [Validation(Required=false)]
            public int? NumType { get; set; }

            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }

            [NameInMap("RobotId")]
            [Validation(Required=false)]
            public string RobotId { get; set; }

            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            [NameInMap("RobotType")]
            [Validation(Required=false)]
            public int? RobotType { get; set; }

            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public long? RuleCode { get; set; }

            [NameInMap("GmtCreateStr")]
            [Validation(Required=false)]
            public string GmtCreateStr { get; set; }

        }

    }

}
