// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210903.Models
{
    public class GetConnectionTicketResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aig-53fvrq1oanz6cxzi3</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ai-gc1gemx6vpa6vlync</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("AvatarId")]
        [Validation(Required=false)]
        public string AvatarId { get; set; }

        [NameInMap("BindQueueInfo")]
        [Validation(Required=false)]
        public GetConnectionTicketResponseBodyBindQueueInfo BindQueueInfo { get; set; }
        public class GetConnectionTicketResponseBodyBindQueueInfo : TeaModel {
            [NameInMap("QueueStatus")]
            [Validation(Required=false)]
            public string QueueStatus { get; set; }

            [NameInMap("Rank")]
            [Validation(Required=false)]
            public int? Rank { get; set; }

            [NameInMap("ReadyTimeout")]
            [Validation(Required=false)]
            public long? ReadyTimeout { get; set; }

            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public long? RemainingTime { get; set; }

            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("WaitTime")]
            [Validation(Required=false)]
            public long? WaitTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalError.TicketGenInternalError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v15418e331d8d068c29411646996786785303b8f61fd880aeaa50c5b584443cd9e65cc7eec72acdaad0a844666a3b26dab</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>reenter app instance failed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetConnectionTicketResponseBodyPolicy Policy { get; set; }
        public class GetConnectionTicketResponseBodyPolicy : TeaModel {
            [NameInMap("ResolutionAdaptive")]
            [Validation(Required=false)]
            public string ResolutionAdaptive { get; set; }

            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD2D0761-1FE5-549D-B169-D3F8D19C6CDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RetryTimes")]
        [Validation(Required=false)]
        public int? RetryTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f3d1b31c-605e-4d04-a896-015fc9fc03b4</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>n7n9bqZlPrvgUOPSJzfdb$89jWwlVISgrchpY0tOfVYGBBcdoPoH39PVHK63fQTEM14kzajQdWAnHTnSicc35W_eI2LbTSGKquKukwcU7opRwmInhtQH<em>mlmsZQ3ByOLYVmqI</em>1hFESs0</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
