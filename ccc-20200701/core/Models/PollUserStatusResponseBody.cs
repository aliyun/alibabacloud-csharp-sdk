// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class PollUserStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PollUserStatusResponseBodyData Data { get; set; }
        public class PollUserStatusResponseBodyData : TeaModel {
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public PollUserStatusResponseBodyDataCallContext CallContext { get; set; }
            public class PollUserStatusResponseBodyDataCallContext : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>OUTBOUND</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a=b;c=d</para>
                /// </summary>
                [NameInMap("CallVariables")]
                [Validation(Required=false)]
                public string CallVariables { get; set; }

                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<PollUserStatusResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class PollUserStatusResponseBodyDataCallContextChannelContexts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OUTBOUND</para>
                    /// </summary>
                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public string CallType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MONITORING</para>
                    /// </summary>
                    [NameInMap("ChannelFlags")]
                    [Validation(Required=false)]
                    public string ChannelFlags { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ch:user:1390501****-&gt;8032****:1609138902226:job-653821410368****</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CREATED</para>
                    /// </summary>
                    [NameInMap("ChannelState")]
                    [Validation(Required=false)]
                    public string ChannelState { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("ChannelVariables")]
                    [Validation(Required=false)]
                    public string ChannelVariables { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1390501****</para>
                    /// </summary>
                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>job-6538214103685****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0830019****</para>
                    /// </summary>
                    [NameInMap("Originator")]
                    [Validation(Required=false)]
                    public string Originator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1390501****</para>
                    /// </summary>
                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>404 - No destination</para>
                    /// </summary>
                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>skillgroup@ccc-test</para>
                    /// </summary>
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1609138903315</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8032****</para>
                    /// </summary>
                    [NameInMap("UserExtension")]
                    [Validation(Required=false)]
                    public string UserExtension { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-6538214103685****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            [NameInMap("ChatContexts")]
            [Validation(Required=false)]
            public List<PollUserStatusResponseBodyDataChatContexts> ChatContexts { get; set; }
            public class PollUserStatusResponseBodyDataChatContexts : TeaModel {
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

                [NameInMap("Members")]
                [Validation(Required=false)]
                public List<PollUserStatusResponseBodyDataChatContextsMembers> Members { get; set; }
                public class PollUserStatusResponseBodyDataChatContextsMembers : TeaModel {
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("UserType")]
                    [Validation(Required=false)]
                    public string UserType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>103655</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public PollUserStatusResponseBodyDataUserContext UserContext { get; set; }
            public class PollUserStatusResponseBodyDataUserContext : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Warm-up</para>
                /// </summary>
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACC-YUNBS-1.0.10-****</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1609136956378</para>
                /// </summary>
                [NameInMap("Heartbeat")]
                [Validation(Required=false)]
                public long? Heartbeat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-6538214103685****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1324730****</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                [NameInMap("ParallelJobList")]
                [Validation(Required=false)]
                public List<PollUserStatusResponseBodyDataUserContextParallelJobList> ParallelJobList { get; set; }
                public class PollUserStatusResponseBodyDataUserContextParallelJobList : TeaModel {
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1609136956378</para>
                /// </summary>
                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("SignedSkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SignedSkillGroupIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BREAK</para>
                /// </summary>
                [NameInMap("UserState")]
                [Validation(Required=false)]
                public string UserState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ON_SITE</para>
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
