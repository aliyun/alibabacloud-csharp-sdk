// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UnmuteCallResponseBody : TeaModel {
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
        /// <para>[responses_200_schema_properties_Data_properties_UserContext_properties_Heartbeat_description]The UNIX timestamp in milliseconds indicating when the last heartbeat was received from the agent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UnmuteCallResponseBodyData Data { get; set; }
        public class UnmuteCallResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_ReleaseReason_type]string</para>
            /// </summary>
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public UnmuteCallResponseBodyDataCallContext CallContext { get; set; }
            public class UnmuteCallResponseBodyDataCallContext : TeaModel {
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
                /// <para>List of call channels.</para>
                /// </summary>
                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<UnmuteCallResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class UnmuteCallResponseBodyDataCallContextChannelContexts : TeaModel {
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
                    /// <para>ch:user:1390501****-&gt;8032****:1609138902226:job-6538214103685****</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <para>[parameters_JobId_schema_description]The call ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATED</para>
                    /// </summary>
                    [NameInMap("ChannelState")]
                    [Validation(Required=false)]
                    public string ChannelState { get; set; }

                    /// <summary>
                    /// <para>Called party of the call channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1390501****</para>
                    /// </summary>
                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    /// <summary>
                    /// <para>An auto-incremented ID assigned by the system. Customers do not need to concern themselves with this value.</para>
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
                    /// <para>job-6538214103685****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The originator of the channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0830019****</para>
                    /// </summary>
                    [NameInMap("Originator")]
                    [Validation(Required=false)]
                    public string Originator { get; set; }

                    /// <summary>
                    /// <para>[parameters_JobId_in]query</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1390501****</para>
                    /// </summary>
                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    /// <summary>
                    /// <para>The reason for releasing the channel. This indicates why the current channel was disconnected. The value corresponds to a response code defined in the SIP protocol. Customers should refer to the SIP protocol to analyze the disconnection reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>404 - No destination</para>
                    /// </summary>
                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    /// <summary>
                    /// <para>The skill group associated with this call. In inbound scenarios, the skill group is specified by the queue routed through IVR. In outbound scenarios, the skill group is the first one the agent signs into.</para>
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
                    /// <para>1609138903315</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The extension number of the agent associated with the channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8032****</para>
                    /// </summary>
                    [NameInMap("UserExtension")]
                    [Validation(Required=false)]
                    public string UserExtension { get; set; }

                    /// <summary>
                    /// <para>The agent ID associated with the channel. This field is empty if the channel belongs to a customer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_ChannelFlags_enumValueTitles_MONITORING]Monitoring</para>
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
                /// <para>job-6538214103685****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <para>[responses_200_schema_properties_Data_properties_UserContext_properties_OutboundScenario_description]Indicates whether the agent is in outbound-only mode.</para>
            /// </summary>
            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public UnmuteCallResponseBodyDataUserContext UserContext { get; set; }
            public class UnmuteCallResponseBodyDataUserContext : TeaModel {
                /// <summary>
                /// <para>Break status code, which can be either system-defined or customer-defined. System-defined break codes include: Warm-up (temporary break state after an agent goes online but before becoming idle), RingingTimeout (break caused by agent ringing timeout), and RejectCall (break caused by agent rejecting a call). Customer-defined status codes have no restrictions, and customers can define them according to their business needs.</para>
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
                /// <para>[responses_200_schema_properties_Data_properties_UserContext_properties_Mobile_description]The agent\&quot;s personal phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp in milliseconds indicating when the last heartbeat was received from the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1609136956378</para>
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
                /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_SkillGroupId_type]string</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-6538214103685****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The agent\&quot;s personal phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1324730****</para>
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
                /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_ChannelId_type]string</para>
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
                /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_CallType_description]Call type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TALKING</para>
                /// </summary>
                [NameInMap("UserState")]
                [Validation(Required=false)]
                public string UserState { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_Index_type]integer</para>
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
        /// <para>[responses_200_schema_properties_Data_properties_UserContext_properties_UserId_type]string</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>[responses_200_schema_properties_Data_properties_UserContext_properties_InstanceId_type]string</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>[responses_200_schema_properties_Data_properties_UserContext_properties_BreakCode_enumValueTitles_RejectCall]Break caused by agent rejecting a call</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>[responses_200_schema_properties_Data_properties_UserContext_properties_DeviceId_type]string</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
