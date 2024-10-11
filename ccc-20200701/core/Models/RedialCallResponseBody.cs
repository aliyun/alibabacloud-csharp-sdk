// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class RedialCallResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RedialCallResponseBodyData Data { get; set; }
        public class RedialCallResponseBodyData : TeaModel {
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public RedialCallResponseBodyDataCallContext CallContext { get; set; }
            public class RedialCallResponseBodyDataCallContext : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>OUTBOUND</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<RedialCallResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class RedialCallResponseBodyDataCallContextChannelContexts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OUTBOUND</para>
                    /// </summary>
                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public string CallType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>COACHING</para>
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
                    /// <para>8001****</para>
                    /// </summary>
                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>job-6573574060089****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1318888****</para>
                    /// </summary>
                    [NameInMap("Originator")]
                    [Validation(Required=false)]
                    public string Originator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>139xxxx0501</para>
                    /// </summary>
                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>486:USER_BUSY</para>
                    /// </summary>
                    [NameInMap("ReleaseReason")]
                    [Validation(Required=false)]
                    public string ReleaseReason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1609138903315</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8000****</para>
                    /// </summary>
                    [NameInMap("UserExtension")]
                    [Validation(Required=false)]
                    public string UserExtension { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>samzhang@abc</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public RedialCallResponseBodyDataUserContext UserContext { get; set; }
            public class RedialCallResponseBodyDataUserContext : TeaModel {
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8000****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-6573574060089****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                [NameInMap("SignedSkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SignedSkillGroupIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>samzhang@abc</para>
                /// </summary>
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
        /// <para>BF268B34-09C2-43FD-BAC4-5D31EA63****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
