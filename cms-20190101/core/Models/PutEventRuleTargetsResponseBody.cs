// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>This parameter is returned if the specified alert contact groups in the request failed to be created or modified.</para>
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
                /// <para>The name of the alert contact group.</para>
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                /// <summary>
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The alert notification methods. Valid values:</para>
                /// <para>4: Alert notifications are sent by using DingTalk and emails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is returned if the specified functions in the request failed to be created or modified in Function Compute.</para>
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
                /// <para>The name of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>functionTest1</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The name of the Function Compute service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>serviceTest1</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is returned if the specified queues in the request failed to be created or modified in SMQ.</para>
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
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The name of the MNS queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testQueue</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of resources that failed to be created or modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FailedParameterCount")]
        [Validation(Required=false)]
        public string FailedParameterCount { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>409C64DA-CF14-45DF-B463-471C790DD15A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
