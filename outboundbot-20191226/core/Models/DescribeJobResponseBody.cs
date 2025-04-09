// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyJob Job { get; set; }
        public class DescribeJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1640068026385</para>
            /// </summary>
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>137****7777</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;057126883106&quot;]</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobContacts> Contacts { get; set; }
            public class DescribeJobResponseBodyJobContacts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>db3db762-e421-44c9-9a01-cb423470757c</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("Honorific")]
                [Validation(Required=false)]
                public string Honorific { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>72dcd26b-f12d-4c27-b3af-18f6aed5b160</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1358****8888</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DsReport")]
            [Validation(Required=false)]
            public string DsReport { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobExtras> Extras { get; set; }
            public class DescribeJobResponseBodyJobExtras : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>djrq</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-08-21 09:49:59.0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NoAnswer</para>
            /// </summary>
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640068026385</para>
            /// </summary>
            [NameInMap("NextExecutionTime")]
            [Validation(Required=false)]
            public long? NextExecutionTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public DescribeJobResponseBodyJobScript Script { get; set; }
            public class DescribeJobResponseBodyJobScript : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;AppKey\&quot;:\&quot;3GHttnsvir1FeWWb\&quot;}</para>
                /// </summary>
                [NameInMap("AsrConfig")]
                [Validation(Required=false)]
                public string AsrConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>chatbot-cn-EJfqqa***</para>
                /// </summary>
                [NameInMap("ChatbotId")]
                [Validation(Required=false)]
                public string ChatbotId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("DebugStatus")]
                [Validation(Required=false)]
                public string DebugStatus { get; set; }

                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDebugDrafted")]
                [Validation(Required=false)]
                public bool? IsDebugDrafted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDrafted")]
                [Validation(Required=false)]
                public bool? IsDrafted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MiniPlaybackConfigEnabled")]
                [Validation(Required=false)]
                public bool? MiniPlaybackConfigEnabled { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("ScriptDescription")]
                [Validation(Required=false)]
                public string ScriptDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>810b5872-57f0-4b27-80ab-7b3f4d8a6374</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;voice\&quot;:\&quot;xiaobei\&quot;,\&quot;volume\&quot;:\&quot;50\&quot;,\&quot;speechRate\&quot;:\&quot;-150\&quot;,\&quot;pitchRate\&quot;:\&quot;0\&quot;}</para>
                /// </summary>
                [NameInMap("TtsConfig")]
                [Validation(Required=false)]
                public string TtsConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1578881227000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c8a2b7f2-ad1a-4865-b872-d0080d9802d9</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobSummary> Summary { get; set; }
            public class DescribeJobResponseBodyJobSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>score</para>
                /// </summary>
                [NameInMap("SummaryName")]
                [Validation(Required=false)]
                public string SummaryName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SystemPriority")]
            [Validation(Required=false)]
            public int? SystemPriority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobTasks> Tasks { get; set; }
            public class DescribeJobResponseBodyJobTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("ActualTime")]
                [Validation(Required=false)]
                public long? ActualTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Brief")]
                [Validation(Required=false)]
                public string Brief { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1528189846043</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>135****8888</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0571****3106</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ChatbotId")]
                [Validation(Required=false)]
                public string ChatbotId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Contact")]
                [Validation(Required=false)]
                public DescribeJobResponseBodyJobTasksContact Contact { get; set; }
                public class DescribeJobResponseBodyJobTasksContact : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>db3db762-e421-44c9-9a01-cb423470757c</para>
                    /// </summary>
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    [NameInMap("Honorific")]
                    [Validation(Required=false)]
                    public string Honorific { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1351****8888</para>
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                    /// </summary>
                    [NameInMap("ReferenceId")]
                    [Validation(Required=false)]
                    public string ReferenceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Conversation")]
                [Validation(Required=false)]
                public List<DescribeJobResponseBodyJobTasksConversation> Conversation { get; set; }
                public class DescribeJobResponseBodyJobTasksConversation : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Broadcast</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("ActionParams")]
                    [Validation(Required=false)]
                    public string ActionParams { get; set; }

                    [NameInMap("Script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>fd279983-93b9-b13b-9a34-64e5df473225</para>
                    /// </summary>
                    [NameInMap("SequenceId")]
                    [Validation(Required=false)]
                    public string SequenceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Robot</para>
                    /// </summary>
                    [NameInMap("Speaker")]
                    [Validation(Required=false)]
                    public string Speaker { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<DescribeJobResponseBodyJobTasksConversationSummary> Summary { get; set; }
                    public class DescribeJobResponseBodyJobTasksConversationSummary : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>score</para>
                        /// </summary>
                        [NameInMap("SummaryName")]
                        [Validation(Required=false)]
                        public string SummaryName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1579068424883</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public string EndReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>client</para>
                /// </summary>
                [NameInMap("HangUpDirection")]
                [Validation(Required=false)]
                public string HangUpDirection { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("PlanedTime")]
                [Validation(Required=false)]
                public long? PlanedTime { get; set; }

                [NameInMap("RealRingingDuration")]
                [Validation(Required=false)]
                public long? RealRingingDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("RingingDuration")]
                [Validation(Required=false)]
                public long? RingingDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SipCode")]
                [Validation(Required=false)]
                public string SipCode { get; set; }

                [NameInMap("SipDuration")]
                [Validation(Required=false)]
                public long? SipDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ff44709e-39a6-43ba-959b-20fcabe3e496</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
