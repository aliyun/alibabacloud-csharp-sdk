// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class RedialCallResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of &quot;OK&quot; indicates that the request succeeded. For other error codes, see the error code list.</para>
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
        public RedialCallResponseBodyData Data { get; set; }
        public class RedialCallResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Call context environment.</para>
            /// </summary>
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public RedialCallResponseBodyDataCallContext CallContext { get; set; }
            public class RedialCallResponseBodyDataCallContext : TeaModel {
                /// <summary>
                /// <para>The call type, indicating the type of the call when it was initially initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OUTBOUND</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>The list of call channels.</para>
                /// </summary>
                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<RedialCallResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class RedialCallResponseBodyDataCallContextChannelContexts : TeaModel {
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
                    /// <para>Call channel flags.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COACHING</para>
                    /// </summary>
                    [NameInMap("ChannelFlags")]
                    [Validation(Required=false)]
                    public string ChannelFlags { get; set; }

                    /// <summary>
                    /// <para>Channel ID.</para>
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
                    /// <para>CREATED</para>
                    /// </summary>
                    [NameInMap("ChannelState")]
                    [Validation(Required=false)]
                    public string ChannelState { get; set; }

                    /// <summary>
                    /// <para>The callee of the voice channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8001****</para>
                    /// </summary>
                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    /// <summary>
                    /// <para>Call job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>job-6573574060089****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The calling party of the call channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1318888****</para>
                    /// </summary>
                    [NameInMap("Originator")]
                    [Validation(Required=false)]
                    public string Originator { get; set; }

                    /// <summary>
                    /// <para>The party that initiated the hang-up of the call channel, indicating who first terminated the call.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>139xxxx0501</para>
                    /// </summary>
                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    /// <summary>
                    /// <para>The release reason of the voice channel, indicating why the current voice channel was released. The value is derived from the response codes defined in the SIP protocol. Customers can refer to the SIP protocol to analyze the release reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>486:USER_BUSY</para>
                    /// </summary>
                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    /// <summary>
                    /// <para>UNIX timestamp of the last status change.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1609138903315</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>User extension number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8000****</para>
                    /// </summary>
                    [NameInMap("UserExtension")]
                    [Validation(Required=false)]
                    public string UserExtension { get; set; }

                    /// <summary>
                    /// <para>Agent User ID information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>samzhang@abc</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>Cloud Contact Center instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The call job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-6538214103685****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <para>Context ID, strictly ordered and incrementing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            /// <summary>
            /// <para>Agent context environment.</para>
            /// </summary>
            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public RedialCallResponseBodyDataUserContext UserContext { get; set; }
            public class RedialCallResponseBodyDataUserContext : TeaModel {
                /// <summary>
                /// <para>Break status code, which is divided into system-defined and customer-defined types.</para>
                /// <para>System-defined break codes:</para>
                /// <list type="bullet">
                /// <item><description><para>Warm-up: A temporary break state after an agent is published but before becoming idle.</para>
                /// </description></item>
                /// <item><description><para>RingingTimeout: A break caused by ringing timeout for the agent.</para>
                /// </description></item>
                /// <item><description><para>RejectCall: A break caused by the agent rejecting a call.</para>
                /// </description></item>
                /// </list>
                /// <para>There are no restrictions on customer-defined status codes. Customers can define them according to their business needs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Warm-up</para>
                /// </summary>
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                /// <summary>
                /// <para>Device ID, which is the identity of a browser-based Web Real-Time Communication (WebRTC) softphone or a physical phone device. Only one type of device can be registered at a time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CCC-x.x.x.x-chrome102-bsdf911812c60f61e</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>User extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8000****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Call job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-6573574060089****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent is in outbound-only mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                /// <summary>
                /// <para>List of skill group IDs that the agent has signed into.</para>
                /// </summary>
                [NameInMap("SignedSkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SignedSkillGroupIdList { get; set; }

                /// <summary>
                /// <para>Agent User ID information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>samzhang@abc</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Agent status. Enumeration values:</para>
                /// <list type="bullet">
                /// <item><description><para>READY: idle</para>
                /// </description></item>
                /// <item><description><para>WORKING: post-processing</para>
                /// </description></item>
                /// <item><description><para>DIALING: dial-up</para>
                /// </description></item>
                /// <item><description><para>BREAK: break</para>
                /// </description></item>
                /// <item><description><para>OFFLINE: offline</para>
                /// </description></item>
                /// <item><description><para>TALKING: talking</para>
                /// </description></item>
                /// <item><description><para>RINGING: ringing</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>READY</para>
                /// </summary>
                [NameInMap("UserState")]
                [Validation(Required=false)]
                public string UserState { get; set; }

                /// <summary>
                /// <para>Work mode. Enumeration values:</para>
                /// <list type="bullet">
                /// <item><description><para>ON_SITE: On-site mode</para>
                /// </description></item>
                /// <item><description><para>OFF_SITE: Off-site mode</para>
                /// </description></item>
                /// <item><description><para>OFFICE_PHONE: Office phone mode</para>
                /// </description></item>
                /// </list>
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
        /// <para>Response message</para>
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
        /// <para>BF268B34-09C2-43FD-BAC4-5D31EA63****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
