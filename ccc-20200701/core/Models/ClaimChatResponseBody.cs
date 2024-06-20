// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ClaimChatResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClaimChatResponseBodyData Data { get; set; }
        public class ClaimChatResponseBodyData : TeaModel {
            [NameInMap("ChatContexts")]
            [Validation(Required=false)]
            public List<ClaimChatResponseBodyDataChatContexts> ChatContexts { get; set; }
            public class ClaimChatResponseBodyDataChatContexts : TeaModel {
                [NameInMap("AccessChannelId")]
                [Validation(Required=false)]
                public string AccessChannelId { get; set; }

                [NameInMap("AccessChannelName")]
                [Validation(Required=false)]
                public string AccessChannelName { get; set; }

                [NameInMap("AccessChannelType")]
                [Validation(Required=false)]
                public string AccessChannelType { get; set; }

                [NameInMap("BeingAssigned")]
                [Validation(Required=false)]
                public bool? BeingAssigned { get; set; }

                [NameInMap("CallVariables")]
                [Validation(Required=false)]
                public string CallVariables { get; set; }

                [NameInMap("ChatType")]
                [Validation(Required=false)]
                public string ChatType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public ClaimChatResponseBodyDataUserContext UserContext { get; set; }
            public class ClaimChatResponseBodyDataUserContext : TeaModel {
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("DeviceState")]
                [Validation(Required=false)]
                public string DeviceState { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("Heartbeat")]
                [Validation(Required=false)]
                public long? Heartbeat { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("SignedSkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SignedSkillGroupIdList { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserState")]
                [Validation(Required=false)]
                public string UserState { get; set; }

                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
