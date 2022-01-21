// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailedContactParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedContactParameters FailedContactParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedContactParameters : TeaModel {
            [NameInMap("ContactParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedContactParametersContactParameter> ContactParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedContactParametersContactParameter : TeaModel {
                public string ContactGroupName { get; set; }
                public int? Id { get; set; }
                public string Level { get; set; }
            }
        };

        [NameInMap("FailedFcParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedFcParameters FailedFcParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedFcParameters : TeaModel {
            [NameInMap("FcParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedFcParametersFcParameter> FcParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedFcParametersFcParameter : TeaModel {
                public string FunctionName { get; set; }
                public int? Id { get; set; }
                public string Region { get; set; }
                public string ServiceName { get; set; }
            }
        };

        [NameInMap("FailedMnsParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedMnsParameters FailedMnsParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedMnsParametersMnsParameter> MnsParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedMnsParametersMnsParameter : TeaModel {
                public int? Id { get; set; }
                public string Queue { get; set; }
                public string Region { get; set; }
            }
        };

        [NameInMap("FailedParameterCount")]
        [Validation(Required=false)]
        public string FailedParameterCount { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
