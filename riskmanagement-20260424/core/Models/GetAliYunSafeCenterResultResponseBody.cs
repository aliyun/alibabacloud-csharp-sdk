// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAliYunSafeCenterResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultResponseBodyData Data { get; set; }
        public class GetAliYunSafeCenterResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public bool? AgentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EcsInstanceStatus")]
            [Validation(Required=false)]
            public bool? EcsInstanceStatus { get; set; }

            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<long?> InstanceIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8169D779-3391-541F-936B-11F4EC09AD0D</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SwasInstanceStatus")]
            [Validation(Required=false)]
            public bool? SwasInstanceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12313123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public bool? TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3C107939-59BD-5EB9-B250-39559C830A85</para>
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
