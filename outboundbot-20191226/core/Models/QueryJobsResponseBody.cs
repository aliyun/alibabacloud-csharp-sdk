// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The job data.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryJobsResponseBodyJobs Jobs { get; set; }
        public class QueryJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The list of jobs.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryJobsResponseBodyJobsList> List { get; set; }
            public class QueryJobsResponseBodyJobsList : TeaModel {
                /// <summary>
                /// <para>The list of calling numbers.</para>
                /// </summary>
                [NameInMap("CallingNumbers")]
                [Validation(Required=false)]
                public List<string> CallingNumbers { get; set; }

                /// <summary>
                /// <para>The contact information. This parameter has been deprecated.</para>
                /// <remarks>
                /// <para>You can retrieve this information by calling the DescribeJob operation.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListContacts> Contacts { get; set; }
                public class QueryJobsResponseBodyJobsListContacts : TeaModel {
                    /// <summary>
                    /// <para>The contact ID.</para>
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
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <para>The honorific title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张先生</para>
                    /// </summary>
                    [NameInMap("Honorific")]
                    [Validation(Required=false)]
                    public string Honorific { get; set; }

                    /// <summary>
                    /// <para>The job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>135****8888</para>
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// <para>The associated business ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                    /// </summary>
                    [NameInMap("ReferenceId")]
                    [Validation(Required=false)]
                    public string ReferenceId { get; set; }

                    /// <summary>
                    /// <para>The role.</para>
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
                    /// <para>The status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Available: Normal.</description></item>
                    /// <item><description>WrongNumber: Wrong number.</description></item>
                    /// <item><description>DoesNotExist: Nonexistent number.</description></item>
                    /// <item><description>Suspended: Call suspended.</description></item>
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
                /// <para>The business data. Displays tag collection results for large language model scenarios.</para>
                /// <remarks>
                /// <para>Keys equal to TenantId or ServiceId are system parameters.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListExtras> Extras { get; set; }
                public class QueryJobsResponseBodyJobsListExtras : TeaModel {
                    /// <summary>
                    /// <para>The business data key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>djrq</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The business data value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-08-21 09:49:59.0</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The failure reason. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Unknown: Unknown error.  </description></item>
                /// <item><description>NoAnswer: No answer.</description></item>
                /// <item><description>InvalidStrategy: Invalid strategy. The strategy configuration is incorrect.</description></item>
                /// <item><description>TimeUp: Timeout detected during scheduling.</description></item>
                /// <item><description>NoStrategy: The strategy is empty or not found.</description></item>
                /// <item><description>CallFailed: Call failed.</description></item>
                /// <item><description>PerDayCallCountLimit: Daily call count limit for the number reached.</description></item>
                /// <item><description>ContactBlockList: The number is on the blocked list.</description></item>
                /// <item><description>EmptyNumber: Nonexistent number. No further outbound calls.</description></item>
                /// <item><description>JobPerDayCallCountLimit: Daily call count limit for the number reached.</description></item>
                /// <item><description>VerificationCancelled: Pre-call verification failed. The call was cancelled.</description></item>
                /// <item><description>ContactSuspended: Call suspended.</description></item>
                /// <item><description>InArrears: Overdue payment.</description></item>
                /// <item><description>OutOfService: Out of service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoAnswer</para>
                /// </summary>
                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                /// <summary>
                /// <para>The job group ID.</para>
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
                /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The associated business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>The scenario ID. This is a legacy parameter and has been deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                /// <summary>
                /// <para>The job status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduling(0): Scheduling.</description></item>
                /// <item><description>Executing(1): Executing.</description></item>
                /// <item><description>Succeeded(2): Completed - Reached.</description></item>
                /// <item><description>Paused(3): Paused.</description></item>
                /// <item><description>Failed(4): Completed - Not reached.</description></item>
                /// <item><description>Cancelled(5): Cancelled - Manual intervention.</description></item>
                /// <item><description>Drafted(6): Draft.</description></item>
                /// </list>
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
                /// <para>The conversation summary. This is a legacy field and is no longer in use. Deprecated.</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListSummary> Summary { get; set; }
                public class QueryJobsResponseBodyJobsListSummary : TeaModel {
                    /// <summary>
                    /// <para>The category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The call record ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>098b9b09-9223-4a8b-a422-99726f0457f3</para>
                    /// </summary>
                    [NameInMap("ConversationDetailId")]
                    [Validation(Required=false)]
                    public string ConversationDetailId { get; set; }

                    /// <summary>
                    /// <para>The job group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ba1ba502-d044-48c0-b710-0f1f840a7c53</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

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
                    /// <para>The summary ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dc67d544-df06-4625-ae48-13e3c9f72d8a</para>
                    /// </summary>
                    [NameInMap("SummaryId")]
                    [Validation(Required=false)]
                    public string SummaryId { get; set; }

                    /// <summary>
                    /// <para>The summary name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>score</para>
                    /// </summary>
                    [NameInMap("SummaryName")]
                    [Validation(Required=false)]
                    public string SummaryName { get; set; }

                    /// <summary>
                    /// <para>The call ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9fdf7a81-6781-4ab8-92fb-1d4231ef365e</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                /// <summary>
                /// <para>The tag hit information in small model scenarios.</para>
                /// </summary>
                [NameInMap("TagHits")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTagHits> TagHits { get; set; }
                public class QueryJobsResponseBodyJobsListTagHits : TeaModel {
                    /// <summary>
                    /// <para>The tag group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>意向收集</para>
                    /// </summary>
                    [NameInMap("TagGroup")]
                    [Validation(Required=false)]
                    public string TagGroup { get; set; }

                    /// <summary>
                    /// <para>The tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>有意向</para>
                    /// </summary>
                    [NameInMap("TagName")]
                    [Validation(Required=false)]
                    public string TagName { get; set; }

                }

                /// <summary>
                /// <para>The call list. This parameter has been deprecated.</para>
                /// <remarks>
                /// <para>You can retrieve this information by calling the searchTask operation.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTasks> Tasks { get; set; }
                public class QueryJobsResponseBodyJobsListTasks : TeaModel {
                    /// <summary>
                    /// <para>The actual outbound call time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579068424883</para>
                    /// </summary>
                    [NameInMap("ActualTime")]
                    [Validation(Required=false)]
                    public long? ActualTime { get; set; }

                    /// <summary>
                    /// <para>The summary. This is a legacy field and is no longer in use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Brief")]
                    [Validation(Required=false)]
                    public string Brief { get; set; }

                    /// <summary>
                    /// <para>SIP call ID。</para>
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
                    /// <para>The chatbot ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ChatbotId")]
                    [Validation(Required=false)]
                    public string ChatbotId { get; set; }

                    /// <summary>
                    /// <para>The contact information.</para>
                    /// </summary>
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public QueryJobsResponseBodyJobsListTasksContact Contact { get; set; }
                    public class QueryJobsResponseBodyJobsListTasksContact : TeaModel {
                        /// <summary>
                        /// <para>The contact ID.</para>
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
                        /// <para>张三</para>
                        /// </summary>
                        [NameInMap("ContactName")]
                        [Validation(Required=false)]
                        public string ContactName { get; set; }

                        /// <summary>
                        /// <para>The honorific title.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>张先生</para>
                        /// </summary>
                        [NameInMap("Honorific")]
                        [Validation(Required=false)]
                        public string Honorific { get; set; }

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
                        /// <para>The contact phone number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>135****8888</para>
                        /// </summary>
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        /// <summary>
                        /// <para>The associated business ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                        /// </summary>
                        [NameInMap("ReferenceId")]
                        [Validation(Required=false)]
                        public string ReferenceId { get; set; }

                        /// <summary>
                        /// <para>The role.</para>
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
                        /// <para>The status.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Available</para>
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                    }

                    /// <summary>
                    /// <para>The call duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

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
                    /// <para>The planned outbound call time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579068424883</para>
                    /// </summary>
                    [NameInMap("PlanedTime")]
                    [Validation(Required=false)]
                    public long? PlanedTime { get; set; }

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
                    /// <para>The task status. Note: The Succeeded status has been subdivided into specific reason types. The Succeeded:1 (Connected) status is no longer returned. Instead, the specific sub-reason type is returned. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>Executing: 0 (Dialing).</para>
                    /// </description></item>
                    /// <item><description><para>Succeeded: 1 (Connected).</para>
                    /// </description></item>
                    /// <item><description><para>NoAnswer: 2 (Not connected - No answer).</para>
                    /// </description></item>
                    /// <item><description><para>NotExist: 3 (Not connected - Nonexistent number).</para>
                    /// </description></item>
                    /// <item><description><para>Busy: 4 (Not connected - Busy).</para>
                    /// </description></item>
                    /// <item><description><para>Cancelled: 5 (Not dialed - Task stopped).</para>
                    /// </description></item>
                    /// <item><description><para>Failed: 6 (Failed).</para>
                    /// </description></item>
                    /// <item><description><para>NotConnected: 7 (Not connected - Unreachable).</para>
                    /// </description></item>
                    /// <item><description><para>PoweredOff: 8 (Not connected - Powered off).</para>
                    /// </description></item>
                    /// <item><description><para>OutOfService: 9 (Not connected - Called party out of service).</para>
                    /// </description></item>
                    /// <item><description><para>InArrears: 10 (Not connected - Called party has overdue payment).</para>
                    /// </description></item>
                    /// <item><description><para>EmptyNumber: 11 (Not dialed - Nonexistent number).</para>
                    /// </description></item>
                    /// <item><description><para>PerDayCallCountLimit: 12 (Not dialed - Daily limit exceeded).</para>
                    /// </description></item>
                    /// <item><description><para>ContactBlockList: 13 (Not dialed - Blocked list).</para>
                    /// </description></item>
                    /// <item><description><para>CallerNotRegistered: 14 (Not dialed - Caller number not registered).</para>
                    /// </description></item>
                    /// <item><description><para>Terminated: 15 (Not dialed - Terminated).</para>
                    /// </description></item>
                    /// <item><description><para>VerificationCancelled: 16 (Not dialed - Pre-call verification failed).</para>
                    /// </description></item>
                    /// <item><description><para>OutOfServiceNoCall: 17 (Not dialed - Called party out of service).</para>
                    /// </description></item>
                    /// <item><description><para>InArrearsNoCall: 18 (Not dialed - Called party has overdue payment).</para>
                    /// </description></item>
                    /// <item><description><para>CallingNumberNotExist: 19 (Not dialed - Caller number does not exist).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededFinish: 20 (Connected - Completed normally).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededChatbotHangUpAfterNoAnswer: 21 (Connected - Robot hung up after no recognition).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededChatbotHangUpAfterSilence: 22 (Connected - Silence timeout hang-up).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededClientHangUpAfterNoAnswer: 23 (Connected - User hung up after no recognition).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededClientHangUp: 24 (Connected - User hung up without reason).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededTransferByIntent: 25 (Connected - Transferred to agent by intent).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededTransferAfterNoAnswer: 26 (Connected - Transferred to agent after no recognition).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededInoInterAction: 27 (Connected - No interaction from user side).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededError: 28 (Connected - System exception interruption).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededSpecialInterceptVoiceAssistant: 29 (Connected - Special intercept - Voice assistant).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededSpecialInterceptExtensionNumberTransfer: 30 (Connected - Special intercept - Extension number transfer).</para>
                    /// </description></item>
                    /// <item><description><para>SucceededSpecialInterceptCustomSpecialIntercept: 31 (Connected - Special intercept - Custom intercept).</para>
                    /// </description></item>
                    /// <item><description><para>HighRiskSipCode: 32 (Not dialed - High risk).</para>
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
                    /// <para>The call ID.</para>
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
