// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAliYunSafeCenterResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>200: Success. Other values (500, 400, etc.): Error codes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultResponseBodyData Data { get; set; }
        public class GetAliYunSafeCenterResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of the Security Center Agent.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public bool? AgentStatus { get; set; }

            /// <summary>
            /// <para>The running status of the ECS instance.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Running.</description></item>
            /// <item><description><b>false</b>: Not running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EcsInstanceStatus")]
            [Validation(Required=false)]
            public bool? EcsInstanceStatus { get; set; }

            /// <summary>
            /// <para>The list of instance IDs of identical security alert events in Security Center.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<long?> InstanceIds { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8169D779-3391-541F-936B-11F4EC09AD0D</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The running status of the simple application server.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Running.</description></item>
            /// <item><description><b>false</b>: Not running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SwasInstanceStatus")]
            [Validation(Required=false)]
            public bool? SwasInstanceStatus { get; set; }

            /// <summary>
            /// <para>The task ID for querying security alerting events triggered by the same rule or alerting type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12313123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>Indicates whether the list of security alerting events that match the same IP rule or same alerting type as the alerting event to be handled is empty.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Empty.</description></item>
            /// <item><description><b>false</b>: Not empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public bool? TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C107939-59BD-5EB9-B250-39559C830A85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API call is successful. Valid values: True/False. This does not indicate the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
