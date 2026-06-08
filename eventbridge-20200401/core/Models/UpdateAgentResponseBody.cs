// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateAgentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateAgentResponseBodyData Data { get; set; }
        public class UpdateAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent ARN</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:eventbridge:{region}:{accountId}:agent/{agentName}</para>
            /// </summary>
            [NameInMap("AgentArn")]
            [Validation(Required=false)]
            public string AgentArn { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidArgument</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>382E6272-XXXXX-A8AF0BFAC1A5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
