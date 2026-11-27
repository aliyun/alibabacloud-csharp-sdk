// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of Success indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The agent information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentByIdResponseBodyData Data { get; set; }
        public class GetAgentByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public int? AgentId { get; set; }

            /// <summary>
            /// <para>The name of the user who created the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The external key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43990666****</para>
            /// </summary>
            [NameInMap("ForeignKey")]
            [Validation(Required=false)]
            public string ForeignKey { get; set; }

            /// <summary>
            /// <para>The logon name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:123@123.com">123@123.com</a></para>
            /// </summary>
            [NameInMap("ForeignNick")]
            [Validation(Required=false)]
            public string ForeignNick { get; set; }

            /// <summary>
            /// <para>The name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Liu Ceshi</para>
            /// </summary>
            [NameInMap("RealName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <para>The service type. Default value: 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ServicerType")]
            [Validation(Required=false)]
            public int? ServicerType { get; set; }

            /// <summary>
            /// <para>The display name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Liu Ceshi</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
