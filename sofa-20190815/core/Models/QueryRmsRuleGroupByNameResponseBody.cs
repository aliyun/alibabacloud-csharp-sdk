// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsRuleGroupByNameResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsRuleGroupByNameResponseBodyResponse Response { get; set; }
        public class QueryRmsRuleGroupByNameResponseBodyResponse : TeaModel {
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public QueryRmsRuleGroupByNameResponseBodyResponseEntity Entity { get; set; }
            public class QueryRmsRuleGroupByNameResponseBodyResponseEntity : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<QueryRmsRuleGroupByNameResponseBodyResponseEntityData> Data { get; set; }
                public class QueryRmsRuleGroupByNameResponseBodyResponseEntityData : TeaModel {
                    [NameInMap("MonitorItemType")]
                    [Validation(Required=false)]
                    public string MonitorItemType { get; set; }

                    [NameInMap("MonitorOptionKey")]
                    [Validation(Required=false)]
                    public string MonitorOptionKey { get; set; }

                    [NameInMap("MonitorPort")]
                    [Validation(Required=false)]
                    public long? MonitorPort { get; set; }

                    [NameInMap("StatisticalMethod")]
                    [Validation(Required=false)]
                    public string StatisticalMethod { get; set; }

                    [NameInMap("StatisticalPeriod")]
                    [Validation(Required=false)]
                    public long? StatisticalPeriod { get; set; }

                    [NameInMap("TriggerCountThreshold")]
                    [Validation(Required=false)]
                    public string TriggerCountThreshold { get; set; }

                    [NameInMap("TriggerOperator")]
                    [Validation(Required=false)]
                    public string TriggerOperator { get; set; }

                    [NameInMap("TriggerValueThreshold")]
                    [Validation(Required=false)]
                    public long? TriggerValueThreshold { get; set; }

                }

            }
        };

    }

}
