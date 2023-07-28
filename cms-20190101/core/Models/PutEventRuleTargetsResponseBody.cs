// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// The name of the API operation.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The name of the queue. Valid values of N: 1 to 5.
        /// </summary>
        [NameInMap("FailedContactParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedContactParameters FailedContactParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedContactParameters : TeaModel {
            [NameInMap("ContactParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedContactParametersContactParameter> ContactParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedContactParametersContactParameter : TeaModel {
                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        [NameInMap("FailedFcParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedFcParameters FailedFcParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedFcParameters : TeaModel {
            [NameInMap("FcParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedFcParametersFcParameter> FcParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedFcParametersFcParameter : TeaModel {
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        [NameInMap("FailedMnsParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedMnsParameters FailedMnsParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedMnsParametersMnsParameter> MnsParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedMnsParametersMnsParameter : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// The name of the Function Compute service. Valid values of N: 1 to 5.
        /// </summary>
        [NameInMap("FailedParameterCount")]
        [Validation(Required=false)]
        public string FailedParameterCount { get; set; }

        /// <summary>
        /// The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The alert notification methods. Valid values:
        /// 
        /// 4: Alert notifications are sent by using DingTalk chatbots and emails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the role.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
