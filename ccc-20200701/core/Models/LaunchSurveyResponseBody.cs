// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class LaunchSurveyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public LaunchSurveyResponseBodyData Data { get; set; }
        public class LaunchSurveyResponseBodyData : TeaModel {
            [NameInMap("CallContext")]
            [Validation(Required=false)]
            public LaunchSurveyResponseBodyDataCallContext CallContext { get; set; }
            public class LaunchSurveyResponseBodyDataCallContext : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>OUTBOUND</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                [NameInMap("ChannelContexts")]
                [Validation(Required=false)]
                public List<LaunchSurveyResponseBodyDataCallContextChannelContexts> ChannelContexts { get; set; }
                public class LaunchSurveyResponseBodyDataCallContextChannelContexts : TeaModel {
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
                    /// <para>ANSWERED</para>
                    /// </summary>
                    [NameInMap("ChannelState")]
                    [Validation(Required=false)]
                    public string ChannelState { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1318888****</para>
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
                    /// <para>job-6580466654649****</para>
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

                    [NameInMap("ReleaseInitiator")]
                    [Validation(Required=false)]
                    public string ReleaseInitiator { get; set; }

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
                    /// <para>1609250655922</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8001****</para>
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
                /// <para>job-6580466654649****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>102323</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public LaunchSurveyResponseBodyDataUserContext UserContext { get; set; }
            public class LaunchSurveyResponseBodyDataUserContext : TeaModel {
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
                /// <para>8001****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1609250656122</para>
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
                /// <para>job-6580466654649****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1390000****</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1609250655090</para>
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
        /// <para>AF1E5957-5276-48FF-A6E6-347166A4ADCD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
