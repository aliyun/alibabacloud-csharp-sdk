// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// This parameter is returned if the specified alert contact groups in the request failed to be created or modified.
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
                /// The name of the alert contact group.
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The alert level and the corresponding notification methods. Valid values:
                /// 
                /// 4: Alert notifications are sent by using DingTalk chatbots and emails.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        /// <summary>
        /// This parameter is returned if the specified functions in the request failed to be created or modified in Function Compute.
        /// </summary>
        [NameInMap("FailedFcParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedFcParameters FailedFcParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedFcParameters : TeaModel {
            [NameInMap("FcParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedFcParametersFcParameter> FcParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedFcParametersFcParameter : TeaModel {
                /// <summary>
                /// The name of the function.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The name of the Function Compute service.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// This parameter is returned if the specified queues in the request failed to be created or modified in MNS.
        /// </summary>
        [NameInMap("FailedMnsParameters")]
        [Validation(Required=false)]
        public PutEventRuleTargetsResponseBodyFailedMnsParameters FailedMnsParameters { get; set; }
        public class PutEventRuleTargetsResponseBodyFailedMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<PutEventRuleTargetsResponseBodyFailedMnsParametersMnsParameter> MnsParameter { get; set; }
            public class PutEventRuleTargetsResponseBodyFailedMnsParametersMnsParameter : TeaModel {
                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The name of the MNS queue.
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// The number of resources that failed to be created or modified.
        /// </summary>
        [NameInMap("FailedParameterCount")]
        [Validation(Required=false)]
        public string FailedParameterCount { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
