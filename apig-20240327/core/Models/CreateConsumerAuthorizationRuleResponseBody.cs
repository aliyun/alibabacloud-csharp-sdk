// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateConsumerAuthorizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateConsumerAuthorizationRuleResponseBodyData Data { get; set; }
        public class CreateConsumerAuthorizationRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The consumer authorization rule ID. When this ID is used to filter the API list, the response includes only the authorized APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>car-d06p196m1hkg9ukum5pg</para>
            /// </summary>
            [NameInMap("consumerAuthorizationRuleId")]
            [Validation(Required=false)]
            public string ConsumerAuthorizationRuleId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CC83C32-3B5A-57EE-9AFE-D0D51822C7BA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
