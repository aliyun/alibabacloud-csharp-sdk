// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class LaunchSurveyResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public LaunchSurveyResponseBodyData Data { get; set; }
        public class LaunchSurveyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Call context environment.</para>
            /// </summary>
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public LaunchSurveyResponseBodyDataCallContext CallContext { get; set; }
            public class LaunchSurveyResponseBodyDataCallContext : TeaModel {
                /// <summary>
                /// <para>Call type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OUTBOUND</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>List of channels.</para>
                /// </summary>
                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<LaunchSurveyResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class LaunchSurveyResponseBodyDataCallContextChannelContexts : TeaModel {
                    /// <summary>
                    /// <para>The call type of the channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OUTBOUND</para>
                    /// </summary>
                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public string CallType { get; set; }

                    /// <summary>
                    /// <para>Channel flags.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MONITORING</para>
                    /// </summary>
                    [NameInMap("ChannelFlags")]
                    [Validation(Required=false)]
                    public string ChannelFlags { get; set; }

                    /// <summary>
                    /// <para>The channel ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ch:user:1390501****-&gt;8032****:1609138902226:job-653821410368****</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <para>The status of the voice channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ANSWERED</para>
                    /// </summary>
                    [NameInMap("ChannelState")]
                    [Validation(Required=false)]
                    public string ChannelState { get; set; }

                    /// <summary>
                    /// <para>The callee of the voice channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1318888****</para>
                    /// </summary>
                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    /// <summary>
                    /// <para>System auto increment ID, which the customer does not need to concern themselves with.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>The call ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>job-6580466654649****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The originator of the channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1318888****</para>
                    /// </summary>
                    [NameInMap("Originator")]
                    [Validation(Required=false)]
                    public string Originator { get; set; }

                    /// <summary>
                    /// <para>The party that initiated the release of the voice channel, indicating who hung up first.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    /// <summary>
                    /// <para>The reason for releasing the channel, indicating why the current channel was disconnected. The value corresponds to response codes defined in the SIP protocol. Customers should refer to the SIP protocol to analyze the disconnection reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    /// <summary>
                    /// <para>The skill group ID associated with the channel. In inbound scenarios, the associated skill group ID is determined by the agent transfer module configured in the IVR. In outbound scenarios, the associated skill group ID is the first skill group that the agent signed into.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup@ccc-test</para>
                    /// </summary>
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    /// <summary>
                    /// <para>The UNIX timestamp of the most recent status change of the channel, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1609250655922</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The extension number of the agent associated with the channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8001****</para>
                    /// </summary>
                    [NameInMap("UserExtension")]
                    [Validation(Required=false)]
                    public string UserExtension { get; set; }

                    /// <summary>
                    /// <para>The agent ID associated with the channel. This field is empty if the channel belongs to a Customer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-6580466654649****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <para>System auto increment ID. Customers do not need to concern themselves with this.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102323</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            /// <summary>
            /// <para>Agent context environment.</para>
            /// </summary>
            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public LaunchSurveyResponseBodyDataUserContext UserContext { get; set; }
            public class LaunchSurveyResponseBodyDataUserContext : TeaModel {
                /// <summary>
                /// <para>Break status code, which can be either system-defined or customer-defined. System-defined break codes include: Warm-up (temporary break state after agent is published and before becoming idle), RingingTimeout (break caused by agent ringing timeout), and RejectCall (break caused by agent call rejection). Customer-defined status codes have no restrictions, and customers can define them according to their business needs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Warm-up</para>
                /// </summary>
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                /// <summary>
                /// <para>Device ID, which is the identity ID of a browser-based Web Real-Time Communication (WebRTC) softphone or a physical phone device. Only one type of device can be registered at a time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACC-YUNBS-1.0.10-****</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>Agent extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8001****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The time when the last heartbeat was received from the agent, formatted as a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1609250656122</para>
                /// </summary>
                [NameInMap("Heartbeat")]
                [Validation(Required=false)]
                public long? Heartbeat { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-6580466654649****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Agent\&quot;s personal phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1390000****</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent is in outbound-only mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                /// <summary>
                /// <para>The most recent time the agent was reserved. Being reserved means an incoming call will be assigned to the agent shortly. The format is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1609250655090</para>
                /// </summary>
                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                /// <summary>
                /// <para>List of skill group IDs that the agent has signed into.</para>
                /// </summary>
                [NameInMap("SignedSkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SignedSkillGroupIdList { get; set; }

                /// <summary>
                /// <para>Agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Agent status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TALKING</para>
                /// </summary>
                [NameInMap("UserState")]
                [Validation(Required=false)]
                public string UserState { get; set; }

                /// <summary>
                /// <para>Work mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON_SITE</para>
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>List of response parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF1E5957-5276-48FF-A6E6-347166A4ADCD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
