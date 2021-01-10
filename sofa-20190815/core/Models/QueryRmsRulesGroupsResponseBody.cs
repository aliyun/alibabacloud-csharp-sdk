// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsRulesGroupsResponseBody : TeaModel {
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
        public QueryRmsRulesGroupsResponseBodyResponse Response { get; set; }
        public class QueryRmsRulesGroupsResponseBodyResponse : TeaModel {
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public QueryRmsRulesGroupsResponseBodyResponseEntity Entity { get; set; }
            public class QueryRmsRulesGroupsResponseBodyResponseEntity : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<QueryRmsRulesGroupsResponseBodyResponseEntityData> Data { get; set; }
                public class QueryRmsRulesGroupsResponseBodyResponseEntityData : TeaModel {
                    [NameInMap("RuleGroupName")]
                    [Validation(Required=false)]
                    public string RuleGroupName { get; set; }

                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                }

            }
        };

    }

}
