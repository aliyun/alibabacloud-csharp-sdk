// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>Job data.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryJobsResponseBodyJobs Jobs { get; set; }
        public class QueryJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>Job array.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryJobsResponseBodyJobsList> List { get; set; }
            public class QueryJobsResponseBodyJobsList : TeaModel {
                /// <summary>
                /// <para>Caller number list.</para>
                /// </summary>
                [NameInMap("CallingNumbers")]
                [Validation(Required=false)]
                public List<string> CallingNumbers { get; set; }

                /// <summary>
                /// <para>Contact information. This parameter is deprecated.</para>
                /// <remarks>
                /// <para>Use the DescribeJob operation instead.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListContacts> Contacts { get; set; }
                public class QueryJobsResponseBodyJobsListContacts : TeaModel {
                    /// <summary>
                    /// <para>Contact ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>db3db762-e421-44c9-9a01-cb423470757c</para>
                    /// </summary>
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    /// <summary>
                    /// <para>Contact name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <para>Honorific.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张先生</para>
                    /// </summary>
                    [NameInMap("Honorific")]
                    [Validation(Required=false)]
                    public string Honorific { get; set; }

                    /// <summary>
                    /// <para>Job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>Phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>135****8888</para>
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// <para>Associated business ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                    /// </summary>
                    [NameInMap("ReferenceId")]
                    [Validation(Required=false)]
                    public string ReferenceId { get; set; }

                    /// <summary>
                    /// <para>Role.</para>
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
                    /// <para>Status.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Available</para>
                    /// </description></item>
                    /// <item><description><para>WrongNumber</para>
                    /// </description></item>
                    /// <item><description><para>DoesNotExist</para>
                    /// </description></item>
                    /// <item><description><para>Suspended</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>Business data. Shows tag collection status for Large Language Model (LLM) scenarios.</para>
                /// <remarks>
                /// <para>Keys TenantId and ServiceId are system parameters.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListExtras> Extras { get; set; }
                public class QueryJobsResponseBodyJobsListExtras : TeaModel {
                    /// <summary>
                    /// <para>Business data key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>djrq</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Business data value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-08-21 09:49:59.0</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Failure reason.</para>
                /// <list type="bullet">
                /// <item><description><para>Unknown</para>
                /// </description></item>
                /// <item><description><para>NoAnswer</para>
                /// </description></item>
                /// <item><description><para>InvalidStrategy</para>
                /// </description></item>
                /// <item><description><para>TimeUp</para>
                /// </description></item>
                /// <item><description><para>NoStrategy</para>
                /// </description></item>
                /// <item><description><para>CallFailed</para>
                /// </description></item>
                /// <item><description><para>PerDayCallCountLimit</para>
                /// </description></item>
                /// <item><description><para>ContactBlockList</para>
                /// </description></item>
                /// <item><description><para>EmptyNumber</para>
                /// </description></item>
                /// <item><description><para>JobPerDayCallCountLimit</para>
                /// </description></item>
                /// <item><description><para>VerificationCancelled</para>
                /// </description></item>
                /// <item><description><para>ContactSuspended</para>
                /// </description></item>
                /// <item><description><para>InArrears</para>
                /// </description></item>
                /// <item><description><para>OutOfService</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoAnswer</para>
                /// </summary>
                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                /// <summary>
                /// <para>Task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <para>Job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>Associated business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>Scenario ID. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                /// <summary>
                /// <para>Job status.</para>
                /// <list type="bullet">
                /// <item><description><para>Scheduling (0)</para>
                /// </description></item>
                /// <item><description><para>Executing (1)</para>
                /// </description></item>
                /// <item><description><para>Succeeded (2)</para>
                /// </description></item>
                /// <item><description><para>Paused (3)</para>
                /// </description></item>
                /// <item><description><para>Failed (4)</para>
                /// </description></item>
                /// <item><description><para>Cancelled (5)</para>
                /// </description></item>
                /// <item><description><para>Drafted (6)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Strategy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c8a2b7f2-ad1a-4865-b872-d0080d9802d9</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>Conversation summary. This field is deprecated.</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListSummary> Summary { get; set; }
                public class QueryJobsResponseBodyJobsListSummary : TeaModel {
                    /// <summary>
                    /// <para>Category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Call record ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>098b9b09-9223-4a8b-a422-99726f0457f3</para>
                    /// </summary>
                    [NameInMap("ConversationDetailId")]
                    [Validation(Required=false)]
                    public string ConversationDetailId { get; set; }

                    /// <summary>
                    /// <para>Task ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ba1ba502-d044-48c0-b710-0f1f840a7c53</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>Job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>Summary ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dc67d544-df06-4625-ae48-13e3c9f72d8a</para>
                    /// </summary>
                    [NameInMap("SummaryId")]
                    [Validation(Required=false)]
                    public string SummaryId { get; set; }

                    /// <summary>
                    /// <para>Summary name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>score</para>
                    /// </summary>
                    [NameInMap("SummaryName")]
                    [Validation(Required=false)]
                    public string SummaryName { get; set; }

                    /// <summary>
                    /// <para>Call ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9fdf7a81-6781-4ab8-92fb-1d4231ef365e</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                /// <summary>
                /// <para>Tags hit in small model scenarios.</para>
                /// </summary>
                [NameInMap("TagHits")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTagHits> TagHits { get; set; }
                public class QueryJobsResponseBodyJobsListTagHits : TeaModel {
                    /// <summary>
                    /// <para>Tag group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>意向收集</para>
                    /// </summary>
                    [NameInMap("TagGroup")]
                    [Validation(Required=false)]
                    public string TagGroup { get; set; }

                    /// <summary>
                    /// <para>Tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>有意向</para>
                    /// </summary>
                    [NameInMap("TagName")]
                    [Validation(Required=false)]
                    public string TagName { get; set; }

                }

                /// <summary>
                /// <para>Call list. This parameter is deprecated.</para>
                /// <remarks>
                /// <para>Use the searchTask operation instead.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTasks> Tasks { get; set; }
                public class QueryJobsResponseBodyJobsListTasks : TeaModel {
                    /// <summary>
                    /// <para>Actual call time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579068424883</para>
                    /// </summary>
                    [NameInMap("ActualTime")]
                    [Validation(Required=false)]
                    public long? ActualTime { get; set; }

                    /// <summary>
                    /// <para>Summary. This field is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Brief")]
                    [Validation(Required=false)]
                    public string Brief { get; set; }

                    /// <summary>
                    /// <para>SIP call ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1528189846043</para>
                    /// </summary>
                    [NameInMap("CallId")]
                    [Validation(Required=false)]
                    public string CallId { get; set; }

                    /// <summary>
                    /// <para>Callee number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>135****8888</para>
                    /// </summary>
                    [NameInMap("CalledNumber")]
                    [Validation(Required=false)]
                    public string CalledNumber { get; set; }

                    /// <summary>
                    /// <para>Caller number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0571****3106</para>
                    /// </summary>
                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    /// <summary>
                    /// <para>Chatbot ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    /// <summary>
                    /// <para>Contact information.</para>
                    /// </summary>
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public QueryJobsResponseBodyJobsListTasksContact Contact { get; set; }
                    public class QueryJobsResponseBodyJobsListTasksContact : TeaModel {
                        /// <summary>
                        /// <para>Contact ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>db3db762-e421-44c9-9a01-cb423470757c</para>
                        /// </summary>
                        [NameInMap("ContactId")]
                        [Validation(Required=false)]
                        public string ContactId { get; set; }

                        /// <summary>
                        /// <para>Contact name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>张三</para>
                        /// </summary>
                        [NameInMap("ContactName")]
                        [Validation(Required=false)]
                        public string ContactName { get; set; }

                        /// <summary>
                        /// <para>Honorific.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>张先生</para>
                        /// </summary>
                        [NameInMap("Honorific")]
                        [Validation(Required=false)]
                        public string Honorific { get; set; }

                        /// <summary>
                        /// <para>Job ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                        /// </summary>
                        [NameInMap("JobId")]
                        [Validation(Required=false)]
                        public string JobId { get; set; }

                        /// <summary>
                        /// <para>Contact phone number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>135****8888</para>
                        /// </summary>
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        /// <summary>
                        /// <para>Business association ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                        /// </summary>
                        [NameInMap("ReferenceId")]
                        [Validation(Required=false)]
                        public string ReferenceId { get; set; }

                        /// <summary>
                        /// <para>Role.</para>
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
                        /// <para>Status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Available</para>
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                    }

                    /// <summary>
                    /// <para>Call duration in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// <para>Job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>Scheduled call time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579068424883</para>
                    /// </summary>
                    [NameInMap("PlanedTime")]
                    [Validation(Required=false)]
                    public long? PlanedTime { get; set; }

                    /// <summary>
                    /// <para>Scenario ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
                    /// </summary>
                    [NameInMap("ScenarioId")]
                    [Validation(Required=false)]
                    public string ScenarioId { get; set; }

                    /// <summary>
                    /// <para>The status of the task. Valid values are described below. Note that the Succeeded status is subdivided by reason. The generic Succeeded: 1 (Connected) status is no longer returned, and a specific success reason is provided instead.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Executing: 0 (Calling).</para>
                    /// </description></item>
                    /// <item><description><para>Succeeded: 1 (Connected).</para>
                    /// </description></item>
                    /// <item><description><para>NoAnswer: 2 (Not connected – No answer).</para>
                    /// </description></item>
                    /// <item><description><para>NotExist: 3 (Not connected – Nonexistent number).</para>
                    /// </description></item>
                    /// <item><description><para>Busy: 4 (Not connected – Line busy).</para>
                    /// </description></item>
                    /// <item><description><para>Cancelled: 5 (Not dialed – Task stopped).</para>
                    /// </description></item>
                    /// <item><description><para>Failed: 6 (Failed).</para>
                    /// </description></item>
                    /// <item><description><para>NotConnected: 7 (Not connected – Unreachable).</para>
                    /// </description></item>
                    /// <item><description><para>PoweredOff: 8 (Not connected – Powered off).</para>
                    /// </description></item>
                    /// <item><description><para>OutOfService: 9 (Not connected – Service suspended).</para>
                    /// </description></item>
                    /// <item><description><para>InArrears: 10 (Not connected – Account has an overdue payment).</para>
                    /// </description></item>
                    /// <item><description><para>EmptyNumber: 11 (Not dialed – Invalid number).</para>
                    /// </description></item>
                    /// <item><description><para>PerDayCallCountLimit: 12 (Not dialed – Daily call limit exceeded).</para>
                    /// </description></item>
                    /// <item><description><para>ContactBlockList: 13 (Not dialed – Number on blocklist).</para>
                    /// </description></item>
                    /// <item><description><para>CallerNotRegistered: 14 (Not dialed – Caller ID not registered).</para>
                    /// </description></item>
                    /// <item><description><para>Terminated: 15 (Not dialed – Terminated).</para>
                    /// </description></item>
                    /// <item><description><para>VerificationCancelled: 16 (Not dialed – Canceled due to pre-call validation failure).</para>
                    /// </description></item>
                    /// <item><description><para>OutOfServiceNoCall: 17 (Not dialed – Service suspended).</para>
                    /// </description></item>
                    /// <item><description><para>InArrearsNoCall: 18 (Not dialed – Account has an overdue payment).</para>
                    /// </description></item>
                    /// <item><description><para>CallingNumberNotExist: 19 (Not dialed – Caller ID does not exist).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededFinish: 20 (Connected – Completed normally).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededChatbotHangUpAfterNoAnswer: 21 (Connected – Bot hung up due to unrecognized input).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededChatbotHangUpAfterSilence: 22 (Connected – Bot hung up due to a silence timeout).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededClientHangUpAfterNoAnswer: 23 (Connected – User hung up due to unrecognized input).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededClientHangUp: 24 (Connected – User hung up).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededTransferByIntent: 25 (Connected – Transferred to an agent based on an intent match).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededTransferAfterNoAnswer: 26 (Connected – Transferred to an agent due to unrecognized input).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededInoInterAction: 27 (Connected – No user interaction).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededError: 28 (Connected – Call interrupted by a system error).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededSpecialInterceptVoiceAssistant: 29 (Connected – Intercepted by a voice assistant).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededSpecialInterceptExtensionNumberTransfer: 30 (Connected – Intercepted due to an extension transfer).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededSpecialInterceptCustomSpecialIntercept: 31 (Connected – Intercepted by a custom rule).</para>
                    /// </description></item>
                    /// <item><description><para>HighRiskSipCode: 32 (Not dialed – High-risk number).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Succeeded</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Call ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ff44709e-39a6-43ba-959b-20fcabe3e496</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
