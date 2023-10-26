// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ReleaseCallResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReleaseCallResponseBodyData Data { get; set; }
        public class ReleaseCallResponseBodyData : TeaModel {
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public ReleaseCallResponseBodyDataCallContext CallContext { get; set; }
            public class ReleaseCallResponseBodyDataCallContext : TeaModel {
                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<ReleaseCallResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class ReleaseCallResponseBodyDataCallContextChannelContexts : TeaModel {
                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public string CallType { get; set; }

                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    [NameInMap("ChannelState")]
                    [Validation(Required=false)]
                    public string ChannelState { get; set; }

                    [NameInMap("ChannelVariables")]
                    [Validation(Required=false)]
                    public string ChannelVariables { get; set; }

                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("Originator")]
                    [Validation(Required=false)]
                    public string Originator { get; set; }

                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("UserExtension")]
                    [Validation(Required=false)]
                    public string UserExtension { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

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
            public ReleaseCallResponseBodyDataUserContext UserContext { get; set; }
            public class ReleaseCallResponseBodyDataUserContext : TeaModel {
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

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
