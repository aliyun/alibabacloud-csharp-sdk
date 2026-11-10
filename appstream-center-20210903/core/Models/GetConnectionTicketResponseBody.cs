// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210903.Models
{
    public class GetConnectionTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The delivery group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-53fvrq1oa******</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The application instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-gc1gemx6vp******</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        /// <summary>
        /// <para>The persistent session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cdr5c9kl******</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>The user avatar ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("AvatarId")]
        [Validation(Required=false)]
        public string AvatarId { get; set; }

        /// <summary>
        /// <para>The queue information.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("BindQueueInfo")]
        [Validation(Required=false)]
        public GetConnectionTicketResponseBodyBindQueueInfo BindQueueInfo { get; set; }
        public class GetConnectionTicketResponseBodyBindQueueInfo : TeaModel {
            /// <summary>
            /// <para>The queue task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Waiting</para>
            /// </summary>
            [NameInMap("QueueStatus")]
            [Validation(Required=false)]
            public string QueueStatus { get; set; }

            /// <summary>
            /// <para>The ranking information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rank")]
            [Validation(Required=false)]
            public int? Rank { get; set; }

            /// <summary>
            /// <para>The timeout period for manual connection after the turn is reached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ReadyTimeout")]
            [Validation(Required=false)]
            public long? ReadyTimeout { get; set; }

            /// <summary>
            /// <para>The remaining wait time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public long? RemainingTime { get; set; }

            /// <summary>
            /// <para>The queue request key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice******</para>
            /// </summary>
            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            /// <summary>
            /// <para>The queue ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-53fvrq1oa******</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The time already waited in the queue. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("WaitTime")]
            [Validation(Required=false)]
            public long? WaitTime { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError.TicketGenInternalError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The logon token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2c4e2ef03d62******</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reenter app instance failed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The next polling interval, in milliseconds. If this parameter is empty, the value is 1000 ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("NextPollIntervalMs")]
        [Validation(Required=false)]
        public int? NextPollIntervalMs { get; set; }

        /// <summary>
        /// <para>The operating system type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The session policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetConnectionTicketResponseBodyPolicy Policy { get; set; }
        public class GetConnectionTicketResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use adaptive resolution.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The session resolution changes with the terminal display area. In this case, <c>SessionResolutionWidth</c> and <c>SessionResolutionHeight</c> are the maximum values of the resolution change.</description></item>
            /// <item><description><c>false</c>: The session resolution does not change with the terminal display area. In this case, the resolution is fixed to the values of <c>SessionResolutionWidth</c> and <c>SessionResolutionHeight</c>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResolutionAdaptive")]
            [Validation(Required=false)]
            public string ResolutionAdaptive { get; set; }

            /// <summary>
            /// <para>The resolution height, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            /// <summary>
            /// <para>The resolution width, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region to which the delivery group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD2D0761-1FE5-549D-B169******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of retries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RetryTimes")]
        [Validation(Required=false)]
        public int? RetryTimes { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f3d1b31c-605e-******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The tenant ID, which is the Alibaba Cloud account UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1126819517******</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>The connection ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n7n9bqZlPrvgUOPY0tOfVYGBBcdoPoH3******</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
