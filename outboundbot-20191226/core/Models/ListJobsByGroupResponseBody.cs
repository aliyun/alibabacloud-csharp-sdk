// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobsByGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Job array</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public ListJobsByGroupResponseBodyJobs Jobs { get; set; }
        public class ListJobsByGroupResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>Job list</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobsByGroupResponseBodyJobsList> List { get; set; }
            public class ListJobsByGroupResponseBodyJobsList : TeaModel {
                /// <summary>
                /// <para>Caller number list</para>
                /// </summary>
                [NameInMap("CallingNumbers")]
                [Validation(Required=false)]
                public List<string> CallingNumbers { get; set; }

                /// <summary>
                /// <para>Contact list</para>
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<ListJobsByGroupResponseBodyJobsListContacts> Contacts { get; set; }
                public class ListJobsByGroupResponseBodyJobsListContacts : TeaModel {
                    /// <summary>
                    /// <para>Contact ID (system-generated)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>db3db762-e421-44c9-9a01-cb423470757c</para>
                    /// </summary>
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    /// <summary>
                    /// <para>Contact name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <para>Honorific (same as contact name)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张先生</para>
                    /// </summary>
                    [NameInMap("Honorific")]
                    [Validation(Required=false)]
                    public string Honorific { get; set; }

                    /// <summary>
                    /// <para>Job ID (deprecated)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>72dcd26b-f12d-4c27-b3af-18f6aed5b160</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>Phone number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>134********</para>
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// <para>Contact third-party system ID (uploaded by customer)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2fa6bac3-06da-4315-82ab-72d6fd3a6f34</para>
                    /// </summary>
                    [NameInMap("ReferenceId")]
                    [Validation(Required=false)]
                    public string ReferenceId { get; set; }

                    /// <summary>
                    /// <para>Deprecated</para>
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
                    /// <para>Deprecated</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>Business data</para>
                /// <remarks>
                /// <para>TenantId and ServiceId are system-generated. All other parameters are custom.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public List<ListJobsByGroupResponseBodyJobsListExtras> Extras { get; set; }
                public class ListJobsByGroupResponseBodyJobsListExtras : TeaModel {
                    /// <summary>
                    /// <para>Business parameter name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>性别</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>Business parameter value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>男</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The failure reason.</para>
                /// <list type="bullet">
                /// <item><description><para>Unknown: An unknown error occurred.</para>
                /// </description></item>
                /// <item><description><para>NoAnswer: The call was not answered.</para>
                /// </description></item>
                /// <item><description><para>InvalidStrategy: The policy is invalid or incorrectly configured.</para>
                /// </description></item>
                /// <item><description><para>TimeUp: The task timed out during scheduling.</para>
                /// </description></item>
                /// <item><description><para>NoStrategy: The policy is empty or was not found.</para>
                /// </description></item>
                /// <item><description><para>CallFailed: The call failed.</para>
                /// </description></item>
                /// <item><description><para>PerDayCallCountLimit: The daily call limit for the phone number was reached.</para>
                /// </description></item>
                /// <item><description><para>ContactBlockList: The phone number is on the blocklist.</para>
                /// </description></item>
                /// <item><description><para>EmptyNumber: The phone number is nonexistent.</para>
                /// </description></item>
                /// <item><description><para>JobPerDayCallCountLimit: The daily call limit for the phone number within the job was reached.</para>
                /// </description></item>
                /// <item><description><para>VerificationCancelled: The call was canceled because it failed pre-call validation.</para>
                /// </description></item>
                /// <item><description><para>ContactSuspended: Calling to the contact is suspended.</para>
                /// </description></item>
                /// <item><description><para>InArrears: The account has an overdue payment.</para>
                /// </description></item>
                /// <item><description><para>OutOfService: The phone number is out of service.</para>
                /// </description></item>
                /// <item><description><para>NoneRepeatableJobMaxAttemptCountLimit: The non-repeatable job reached the maximum number of attempts.</para>
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
                /// <para>Job ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <para>Job ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Priority</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>Third-party system ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>Scenario ID (legacy parameter)</para>
                /// 
                /// <b>Example:</b>
                /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public string ScenarioId { get; set; }

                /// <summary>
                /// <para>Job status</para>
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
                /// <para>Strategy ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>c8a2b7f2-ad1a-4865-b872-d0080d9802d9</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>Conversation summary (deprecated)</para>
                /// <remarks>
                /// <para>Use the DescribeJob API to retrieve this data.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public List<ListJobsByGroupResponseBodyJobsListSummary> Summary { get; set; }
                public class ListJobsByGroupResponseBodyJobsListSummary : TeaModel {
                    /// <summary>
                    /// <para>Conversation summary category</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Conversation summary content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Call record ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>62a860f5-a8b3-4b75-9512-c7e04bb7c8bc</para>
                    /// </summary>
                    [NameInMap("ConversationDetailId")]
                    [Validation(Required=false)]
                    public string ConversationDetailId { get; set; }

                    /// <summary>
                    /// <para>Job group ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>88e56cfb-33f8-477a-907c-0fe83292d924</para>
                    /// </summary>
                    [NameInMap("JobGroupId")]
                    [Validation(Required=false)]
                    public string JobGroupId { get; set; }

                    /// <summary>
                    /// <para>Job ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f102a853-5f5a-47fb-8869-b31ea74a9620</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>Summary ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>680f1905-81ae-4aab-99dd-2964dfb767fa</para>
                    /// </summary>
                    [NameInMap("SummaryId")]
                    [Validation(Required=false)]
                    public string SummaryId { get; set; }

                    /// <summary>
                    /// <para>Summary name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>score</para>
                    /// </summary>
                    [NameInMap("SummaryName")]
                    [Validation(Required=false)]
                    public string SummaryName { get; set; }

                    /// <summary>
                    /// <para>Call ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b0f35dd1-0337-402e-9c4f-3a6c2426950a</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                /// <summary>
                /// <para>System priority</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SystemPriority")]
                [Validation(Required=false)]
                public int? SystemPriority { get; set; }

            }

            /// <summary>
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
