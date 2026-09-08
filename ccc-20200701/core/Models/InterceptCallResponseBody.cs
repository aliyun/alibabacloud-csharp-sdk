// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class InterceptCallResponseBody : TeaModel {
        /// <summary>
        /// <para>响应码。</para>
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
        public InterceptCallResponseBodyData Data { get; set; }
        public class InterceptCallResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Call context environment.</para>
            /// </summary>
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public InterceptCallResponseBodyDataCallContext CallContext { get; set; }
            public class InterceptCallResponseBodyDataCallContext : TeaModel {
                /// <summary>
                /// <para>The call type of the channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INTERCEPT</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>The list of channels.</para>
                /// </summary>
                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<InterceptCallResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class InterceptCallResponseBodyDataCallContextChannelContexts : TeaModel {
                    /// <summary>
                    /// <para>The call type of the channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INTERCEPT</para>
                    /// </summary>
                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public string CallType { get; set; }

                    /// <summary>
                    /// <para>话务通道标志。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("ChannelFlags")]
                    [Validation(Required=false)]
                    public string ChannelFlags { get; set; }

                    /// <summary>
                    /// <para>话务通道 ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ch:user:1390501****-&gt;8032****:1609138902226:job-653821410368****</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_CallType_enumValueTitles_COACH]Coaching</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ANSWERED</para>
                    /// </summary>
                    [NameInMap("ChannelState")]
                    [Validation(Required=false)]
                    public string ChannelState { get; set; }

                    /// <summary>
                    /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_CallType_enumValueTitles_BARGE]Barge-in</para>
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
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>通话 ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>job-6538214103685****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>话务通道的主叫方。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0830019****</para>
                    /// </summary>
                    [NameInMap("Originator")]
                    [Validation(Required=false)]
                    public string Originator { get; set; }

                    /// <summary>
                    /// <para>[responses_200_schema_properties_Data_properties_CallContext_properties_ChannelContexts_items_properties_CallType_type]string</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1390501****</para>
                    /// </summary>
                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    /// <summary>
                    /// <para>话务通道的挂断原因，表示当前话务通道为什么会被挂断，取值来自 SIP 协议中定义的响应码，请客户参考 SIP 协议分析挂断原因。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>404 - No destination</para>
                    /// </summary>
                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    /// <summary>
                    /// <para>话务通道关联的技能组 ID，呼入场景下，关联的技能组 ID 由 IVR 中转人工模块配置的技能组决定，呼出场景下，关联的技能组 ID 为座席签入的第一个技能组的 ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup@ccc-test</para>
                    /// </summary>
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    /// <summary>
                    /// <para>话务通道最近一次状态变化的时间戳，格式是 Unix 时间戳，单位毫秒。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1609138903315</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>话务通道关联的坐席的分机号。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8032****</para>
                    /// </summary>
                    [NameInMap("UserExtension")]
                    [Validation(Required=false)]
                    public string UserExtension { get; set; }

                    /// <summary>
                    /// <para>话务通道关联的坐席 ID，如果是客户的话务通道，该字段为空。</para>
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
                /// <para>The call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-6538214103685****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <para>Agent context environment.</para>
            /// </summary>
            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public InterceptCallResponseBodyDataUserContext UserContext { get; set; }
            public class InterceptCallResponseBodyDataUserContext : TeaModel {
                /// <summary>
                /// <para>Break status code, which can be either System-defined or Custom-defined. System-defined break codes include: Warm-up (temporary break state after an agent is published and before becoming idle), RingingTimeout (break caused by agent ringing timeout), and RejectCall (break caused by agent call rejection). There are no restrictions on Custom-defined status codes, and customers can define them according to their business needs.</para>
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
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The time when the last heartbeat was received from the agent, formatted as a UNIX timestamp in milliseconds.</para>
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
                /// <para>Call ID.</para>
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
                /// <para>The time when the agent was most recently reserved. Being reserved means an incoming call will be assigned to the agent shortly. The format is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1609136956378</para>
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
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
