// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class EndConferenceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EndConferenceResponseBodyData Data { get; set; }
        public class EndConferenceResponseBodyData : TeaModel {
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public EndConferenceResponseBodyDataCallContext CallContext { get; set; }
            public class EndConferenceResponseBodyDataCallContext : TeaModel {
                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<EndConferenceResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class EndConferenceResponseBodyDataCallContextChannelContexts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OUTBOUND</para>
                    /// </summary>
                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public string CallType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ch:user:131888****-&gt;8001****:1609225718294:job-65700074013925376</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>103655</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public EndConferenceResponseBodyDataUserContext UserContext { get; set; }
            public class EndConferenceResponseBodyDataUserContext : TeaModel {
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
                /// <para>UNREGISTERED</para>
                /// </summary>
                [NameInMap("DeviceState")]
                [Validation(Required=false)]
                public string DeviceState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

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
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

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
                /// <para>TALKING</para>
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
        /// <para>0630E5DF-CEB0-445B-8626-D5C7481181C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
