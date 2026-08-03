// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The job information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyJob Job { get; set; }
        public class DescribeJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> The actual execution time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640068026385</para>
            /// </summary>
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            /// <summary>
            /// <para>The called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137****7777</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <para>The list of calling numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;057126883106&quot;]</para>
            /// </summary>
            [NameInMap("CallingNumbers")]
            [Validation(Required=false)]
            public List<string> CallingNumbers { get; set; }

            /// <summary>
            /// <para>The contact information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobContacts> Contacts { get; set; }
            public class DescribeJobResponseBodyJobContacts : TeaModel {
                /// <summary>
                /// <para>The contact ID. This is system-generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db3db762-e421-44c9-9a01-cb423470757c</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <para>The contact name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San.</para>
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The honorific of the contact. This is the same as the contact name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mr. Zhang.</para>
                /// </summary>
                [NameInMap("Honorific")]
                [Validation(Required=false)]
                public string Honorific { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72dcd26b-f12d-4c27-b3af-18f6aed5b160</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1358****8888</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>The business ID of the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The contact role.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The contact status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b> The tag hit information of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DsReport")]
            [Validation(Required=false)]
            public string DsReport { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The end reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            /// <summary>
            /// <para>The business parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobExtras> Extras { get; set; }
            public class DescribeJobResponseBodyJobExtras : TeaModel {
                /// <summary>
                /// <para>The name of the business parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>djrq</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the business parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-21 09:49:59.0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The reason for the job failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoAnswer</para>
            /// </summary>
            [NameInMap("FailureReason")]
            [Validation(Required=false)]
            public string FailureReason { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The next execution time of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640068026385</para>
            /// </summary>
            [NameInMap("NextExecutionTime")]
            [Validation(Required=false)]
            public long? NextExecutionTime { get; set; }

            /// <summary>
            /// <para>The job priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The business ID of the job, custom-defined by the business side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
            /// </summary>
            [NameInMap("ScenarioId")]
            [Validation(Required=false)]
            public string ScenarioId { get; set; }

            /// <summary>
            /// <para>The script scenario.</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public DescribeJobResponseBodyJobScript Script { get; set; }
            public class DescribeJobResponseBodyJobScript : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b> The ASR configuration of the script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;AppKey\&quot;:\&quot;3GHttnsvir1FeWWb\&quot;}</para>
                /// </summary>
                [NameInMap("AsrConfig")]
                [Validation(Required=false)]
                public string AsrConfig { get; set; }

                /// <summary>
                /// <para>The chatbot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chatbot-cn-EJfqqa***</para>
                /// </summary>
                [NameInMap("ChatbotId")]
                [Validation(Required=false)]
                public string ChatbotId { get; set; }

                /// <summary>
                /// <para>The debug status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("DebugStatus")]
                [Validation(Required=false)]
                public string DebugStatus { get; set; }

                /// <summary>
                /// <para>The industry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finance.</para>
                /// </summary>
                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>Indicates whether the debug version is in draft state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDebugDrafted")]
                [Validation(Required=false)]
                public bool? IsDebugDrafted { get; set; }

                /// <summary>
                /// <para>Indicates whether the script is in draft state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDrafted")]
                [Validation(Required=false)]
                public bool? IsDrafted { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> Specifies whether the tone continuation feature is enabled. No value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MiniPlaybackConfigEnabled")]
                [Validation(Required=false)]
                public bool? MiniPlaybackConfigEnabled { get; set; }

                /// <summary>
                /// <para>The script name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection script.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection.</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The script description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collection script.</para>
                /// </summary>
                [NameInMap("ScriptDescription")]
                [Validation(Required=false)]
                public string ScriptDescription { get; set; }

                /// <summary>
                /// <para>The script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>810b5872-57f0-4b27-80ab-7b3f4d8a6374</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The TTS configuration of the script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;voice\&quot;:\&quot;xiaobei\&quot;,\&quot;volume\&quot;:\&quot;50\&quot;,\&quot;speechRate\&quot;:\&quot;-150\&quot;,\&quot;pitchRate\&quot;:\&quot;0\&quot;}</para>
                /// </summary>
                [NameInMap("TtsConfig")]
                [Validation(Required=false)]
                public string TtsConfig { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578881227000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The strategy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8a2b7f2-ad1a-4865-b872-d0080d9802d9</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

            /// <summary>
            /// <para>The conversation business tag data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobSummary> Summary { get; set; }
            public class DescribeJobResponseBodyJobSummary : TeaModel {
                /// <summary>
                /// <para><b>[Deprecated]</b> The conversation summary category. This is a legacy field and is no longer used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>score</para>
                /// </summary>
                [NameInMap("SummaryName")]
                [Validation(Required=false)]
                public string SummaryName { get; set; }

            }

            /// <summary>
            /// <para>The system priority of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SystemPriority")]
            [Validation(Required=false)]
            public int? SystemPriority { get; set; }

            /// <summary>
            /// <para>The call list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<DescribeJobResponseBodyJobTasks> Tasks { get; set; }
            public class DescribeJobResponseBodyJobTasks : TeaModel {
                /// <summary>
                /// <para>The actual execution time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("ActualTime")]
                [Validation(Required=false)]
                public long? ActualTime { get; set; }

                /// <summary>
                /// <para>The business result. This is a legacy field and is no longer used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Brief")]
                [Validation(Required=false)]
                public string Brief { get; set; }

                /// <summary>
                /// <para>SIP call id。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1528189846043</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>The called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>135****8888</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <para>The calling number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571****3106</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <para>The robot ID for the conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ChatbotId")]
                [Validation(Required=false)]
                public string ChatbotId { get; set; }

                /// <summary>
                /// <para>The contact information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Contact")]
                [Validation(Required=false)]
                public DescribeJobResponseBodyJobTasksContact Contact { get; set; }
                public class DescribeJobResponseBodyJobTasksContact : TeaModel {
                    /// <summary>
                    /// <para>The contact ID. This is system-generated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>db3db762-e421-44c9-9a01-cb423470757c</para>
                    /// </summary>
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    /// <summary>
                    /// <para>The contact name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhang San.</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <para>The honorific of the contact. This is the same as the contact name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mr. Zhang.</para>
                    /// </summary>
                    [NameInMap("Honorific")]
                    [Validation(Required=false)]
                    public string Honorific { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1351****8888</para>
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// <para>The business system ID of the contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                    /// </summary>
                    [NameInMap("ReferenceId")]
                    [Validation(Required=false)]
                    public string ReferenceId { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The contact role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The contact status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>The conversation text list of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Conversation")]
                [Validation(Required=false)]
                public List<DescribeJobResponseBodyJobTasksConversation> Conversation { get; set; }
                public class DescribeJobResponseBodyJobTasksConversation : TeaModel {
                    /// <summary>
                    /// <para>The instruction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Broadcast</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The instruction parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("ActionParams")]
                    [Validation(Required=false)]
                    public string ActionParams { get; set; }

                    /// <summary>
                    /// <para>The conversation text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hello, I am ** customer service.</para>
                    /// </summary>
                    [NameInMap("Script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fd279983-93b9-b13b-9a34-64e5df473225</para>
                    /// </summary>
                    [NameInMap("SequenceId")]
                    [Validation(Required=false)]
                    public string SequenceId { get; set; }

                    /// <summary>
                    /// <para>The speaker of the conversation. Valid values: Robot and Contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Robot</para>
                    /// </summary>
                    [NameInMap("Speaker")]
                    [Validation(Required=false)]
                    public string Speaker { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The conversation summary data. This is a legacy field and is no longer used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<DescribeJobResponseBodyJobTasksConversationSummary> Summary { get; set; }
                    public class DescribeJobResponseBodyJobTasksConversationSummary : TeaModel {
                        /// <summary>
                        /// <para>The conversation summary category. This is a legacy field and is no longer used.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>The summary content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The summary name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>score</para>
                        /// </summary>
                        [NameInMap("SummaryName")]
                        [Validation(Required=false)]
                        public string SummaryName { get; set; }

                    }

                    /// <summary>
                    /// <para>The summary creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579068424883</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// <para>The conversation duration. This field is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The call end reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public string EndReason { get; set; }

                /// <summary>
                /// <para>The actual end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The party that hung up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client</para>
                /// </summary>
                [NameInMap("HangUpDirection")]
                [Validation(Required=false)]
                public string HangUpDirection { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The planned call time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("PlanedTime")]
                [Validation(Required=false)]
                public long? PlanedTime { get; set; }

                /// <summary>
                /// <para>The actual ringing duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("RealRingingDuration")]
                [Validation(Required=false)]
                public long? RealRingingDuration { get; set; }

                /// <summary>
                /// <para>The ringing duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("RingingDuration")]
                [Validation(Required=false)]
                public long? RingingDuration { get; set; }

                /// <summary>
                /// <para>The scenario ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                /// <summary>
                /// <para>The SIP status code of the call task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SipCode")]
                [Validation(Required=false)]
                public string SipCode { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The SIP signaling duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("SipDuration")]
                [Validation(Required=false)]
                public long? SipDuration { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SucceededTransferByIntent</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ff44709e-39a6-43ba-959b-20fcabe3e496</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The total call duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

            }

        }

        /// <summary>
        /// <para>The API response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
