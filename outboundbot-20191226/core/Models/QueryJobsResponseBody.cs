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
            /// <para>The job array.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryJobsResponseBodyJobsList> List { get; set; }
            public class QueryJobsResponseBodyJobsList : TeaModel {
                /// <summary>
                /// <para>The calling number list.</para>
                /// </summary>
                [NameInMap("CallingNumbers")]
                [Validation(Required=false)]
                public List<string> CallingNumbers { get; set; }

                /// <summary>
                /// <para><b>[Deprecated]</b> The contact information.</para>
                /// <remarks>
                /// <para>You can obtain this information by calling the DescribeJob operation.</para>
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
                    /// <para>Zhang San</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <para>The honorific.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mr. Zhang</para>
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
                /// <para>The business data, which displays the tag collection status in large model scenarios.</para>
                /// <remarks>
                /// <para>If the key is TenantId or ServiceId, it is a system parameter.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListExtras> Extras { get; set; }
                public class QueryJobsResponseBodyJobsListExtras : TeaModel {
                    /// <summary>
                    /// <para>The key of the business data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>djrq</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the business data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-08-21 09:49:59.0</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The reason for the failure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Unknown: Unknown error.  </description></item>
                /// <item><description>NoAnswer: No answer.</description></item>
                /// <item><description>InvalidStrategy: Invalid strategy. The strategy configuration is incorrect.</description></item>
                /// <item><description>TimeUp: Timeout detected during scheduling.</description></item>
                /// <item><description>NoStrategy: The strategy is empty or not found.</description></item>
                /// <item><description>CallFailed: Call failed.</description></item>
                /// <item><description>PerDayCallCountLimit: The daily call count limit for the number is reached.</description></item>
                /// <item><description>ContactBlockList: The number is on the outbound call blacklist.</description></item>
                /// <item><description>EmptyNumber: The number is a nonexistent number and will not be called.</description></item>
                /// <item><description>JobPerDayCallCountLimit: The daily call count limit for the number is reached.</description></item>
                /// <item><description>VerificationCancelled: Cancelled due to failed pre-call verification.</description></item>
                /// <item><description>ContactSuspended: Call suspended.</description></item>
                /// <item><description>InArrears: Overdue payment.</description></item>
                /// <item><description>OutOfService: Service suspended.</description></item>
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
                /// <para><b>[Deprecated]</b> The scenario ID. This is a legacy parameter.</para>
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
                /// <item><description>Scheduling(0, &quot;Scheduling&quot;)</description></item>
                /// <item><description>Executing(1, &quot;Executing&quot;)</description></item>
                /// <item><description>Succeeded(2, &quot;Finished - Reached&quot;)</description></item>
                /// <item><description>Paused(3, &quot;Paused&quot;)</description></item>
                /// <item><description>Failed(4, &quot;Finished - Not reached&quot;)</description></item>
                /// <item><description>Cancelled(5, &quot;Cancelled - Manual intervention&quot;)</description></item>
                /// <item><description>Drafted(6, &quot;Draft&quot;)</description></item>
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
                /// <para><b>[Deprecated]</b> The conversation summary. This is a legacy field and is no longer used.</para>
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
                /// <para>The matched tag information in small model scenarios.</para>
                /// </summary>
                [NameInMap("TagHits")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTagHits> TagHits { get; set; }
                public class QueryJobsResponseBodyJobsListTagHits : TeaModel {
                    /// <summary>
                    /// <para>The tag group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Intent collection</para>
                    /// </summary>
                    [NameInMap("TagGroup")]
                    [Validation(Required=false)]
                    public string TagGroup { get; set; }

                    /// <summary>
                    /// <para>The tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Interested</para>
                    /// </summary>
                    [NameInMap("TagName")]
                    [Validation(Required=false)]
                    public string TagName { get; set; }

                }

                /// <summary>
                /// <para><b>[Deprecated]</b> The call list.</para>
                /// <remarks>
                /// <para>You can obtain this information by calling the searchTask operation.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTasks> Tasks { get; set; }
                public class QueryJobsResponseBodyJobsListTasks : TeaModel {
                    /// <summary>
                    /// <para>The actual outbound call time. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579068424883</para>
                    /// </summary>
                    [NameInMap("ActualTime")]
                    [Validation(Required=false)]
                    public long? ActualTime { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The summary. This is a legacy field and is no longer used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Brief")]
                    [Validation(Required=false)]
                    public string Brief { get; set; }

                    /// <summary>
                    /// <para>The SIP call ID.</para>
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
                    /// <para>The robot ID.</para>
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
                        /// <para>Zhang San</para>
                        /// </summary>
                        [NameInMap("ContactName")]
                        [Validation(Required=false)]
                        public string ContactName { get; set; }

                        /// <summary>
                        /// <para>The honorific.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Mr. Zhang</para>
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
                        /// <para>The phone number of the contact.</para>
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
                    /// <para>The planned outbound call time. The value is a UNIX timestamp in milliseconds.</para>
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
                    /// <para>The task status. Note: The Succeeded status is subdivided into specific reasons. The Succeeded: 1 (Connected) status is no longer returned. Instead, specific subdivided reason types are returned. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Executing: 0 (Calling).</description></item>
                    /// <item><description>Succeeded: 1 (Connected).</description></item>
                    /// <item><description>NoAnswer: 2 (Not connected - No answer).</description></item>
                    /// <item><description>NotExist: 3 (Not connected - Nonexistent number).</description></item>
                    /// <item><description>Busy: 4 (Not connected - Busy).</description></item>
                    /// <item><description>Cancelled: 5 (Not called - Task stopped).</description></item>
                    /// <item><description>Failed: 6 (Failed).</description></item>
                    /// <item><description>NotConnected: 7 (Not connected - Unreachable).</description></item>
                    /// <item><description>PoweredOff: 8 (Not connected - Powered off).</description></item>
                    /// <item><description>OutOfService: 9 (Not connected - Callee service suspended).</description></item>
                    /// <item><description>InArrears: 10 (Not connected - Callee overdue payment).</description></item>
                    /// <item><description>EmptyNumber: 11 (Not called - Nonexistent number, no outbound call).</description></item>
                    /// <item><description>PerDayCallCountLimit: 12 (Not called - Daily limit exceeded).</description></item>
                    /// <item><description>ContactBlockList: 13 (Not called - Blacklisted).</description></item>
                    /// <item><description>CallerNotRegistered: 14 (Not called - Caller number not registered).</description></item>
                    /// <item><description>Terminated: 15 (Not called - Terminated).</description></item>
                    /// <item><description>VerificationCancelled: 16 (Not called - Cancelled due to failed pre-call verification).</description></item>
                    /// <item><description>OutOfServiceNoCall: 17 (Not called - Callee service suspended, no outbound call).</description></item>
                    /// <item><description>InArrearsNoCall: 18 (Not called - Callee overdue payment, no outbound call).</description></item>
                    /// <item><description>CallingNumberNotExist: 19 (Not called - Caller number does not exist).</description></item>
                    /// <item><description>SucceededFinish: 20 (Connected - Normally finished).</description></item>
                    /// <item><description>SucceededChatbotHangUpAfterNoAnswer: 21 (Connected - Robot hung up after rejection).</description></item>
                    /// <item><description>SucceededChatbotHangUpAfterSilence: 22 (Connected - Hung up due to silence timeout).</description></item>
                    /// <item><description>SucceededClientHangUpAfterNoAnswer: 23 (Connected - User hung up after rejection).</description></item>
                    /// <item><description>SucceededClientHangUp: 24 (Connected - User hung up without reason).</description></item>
                    /// <item><description>SucceededTransferByIntent: 25 (Connected - Transferred to agent due to intent match).</description></item>
                    /// <item><description>SucceededTransferAfterNoAnswer: 26 (Connected - Transferred to agent after rejection).</description></item>
                    /// <item><description>SucceededInoInterAction: 27 (Connected - No interaction from the user side).</description></item>
                    /// <item><description>SucceededError: 28 (Connected - Interrupted due to system exception).</description></item>
                    /// <item><description>SucceededSpecialInterceptVoiceAssistant: 29 (Connected - Special interception - Voice assistant).</description></item>
                    /// <item><description>SucceededSpecialInterceptExtensionNumberTransfer: 30 (Connected - Special interception - Extension number transfer).</description></item>
                    /// <item><description>SucceededSpecialInterceptCustomSpecialIntercept: 31 (Connected - Special interception - Custom interception).</description></item>
                    /// <item><description>HighRiskSipCode: 32 (Not called - High risk, no outbound call).</description></item>
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
            /// <para>The total number of entries.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
