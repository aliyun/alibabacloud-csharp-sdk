// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value Success indicates that the request is successful. Other values indicate that the request failed. For more information about error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateRuleResponseBodyData Data { get; set; }
        public class CreateRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ARN of the event rule, which is used for authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:eventbridge:cn-hangzhou:123456789098****:eventbus/default/rule/MNSRule</para>
            /// </summary>
            [NameInMap("RuleARN")]
            [Validation(Required=false)]
            public string RuleARN { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remote error. requestId: [xxxx], error code: [xxx], message: [The target in event rule is invalid! Endpoint is xxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD6D598-7506-5D2C-81EA-30E3241A903A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. A value of true indicates that the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
