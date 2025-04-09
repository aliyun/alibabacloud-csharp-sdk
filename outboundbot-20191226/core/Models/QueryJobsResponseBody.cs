// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsResponseBody : TeaModel {
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

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryJobsResponseBodyJobs Jobs { get; set; }
        public class QueryJobsResponseBodyJobs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryJobsResponseBodyJobsList> List { get; set; }
            public class QueryJobsResponseBodyJobsList : TeaModel {
                [NameInMap("CallingNumbers")]
                [Validation(Required=false)]
                public List<string> CallingNumbers { get; set; }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListContacts> Contacts { get; set; }
                public class QueryJobsResponseBodyJobsListContacts : TeaModel {
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
                    /// <para>135****8888</para>
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

                [NameInMap("Extras")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListExtras> Extras { get; set; }
                public class QueryJobsResponseBodyJobsListExtras : TeaModel {
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
                /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fce6c599-8ede-40e3-9f78-0928eda7b4e8</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
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

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListSummary> Summary { get; set; }
                public class QueryJobsResponseBodyJobsListSummary : TeaModel {
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
                    /// <para>098b9b09-9223-4a8b-a422-99726f0457f3</para>
                    /// </summary>
                    [NameInMap("ConversationDetailId")]
                    [Validation(Required=false)]
                    public string ConversationDetailId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ba1ba502-d044-48c0-b710-0f1f840a7c53</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>994b8baf-7ef8-480c-b141-b7b6db77c4df</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dc67d544-df06-4625-ae48-13e3c9f72d8a</para>
                    /// </summary>
                    [NameInMap("SummaryId")]
                    [Validation(Required=false)]
                    public string SummaryId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>score</para>
                    /// </summary>
                    [NameInMap("SummaryName")]
                    [Validation(Required=false)]
                    public string SummaryName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9fdf7a81-6781-4ab8-92fb-1d4231ef365e</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                [NameInMap("TagHits")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTagHits> TagHits { get; set; }
                public class QueryJobsResponseBodyJobsListTagHits : TeaModel {
                    [NameInMap("TagGroup")]
                    [Validation(Required=false)]
                    public string TagGroup { get; set; }

                    [NameInMap("TagName")]
                    [Validation(Required=false)]
                    public string TagName { get; set; }

                }

                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<QueryJobsResponseBodyJobsListTasks> Tasks { get; set; }
                public class QueryJobsResponseBodyJobsListTasks : TeaModel {
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

                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public QueryJobsResponseBodyJobsListTasksContact Contact { get; set; }
                    public class QueryJobsResponseBodyJobsListTasksContact : TeaModel {
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
                        /// <para>135****8888</para>
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
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ade80092-03d9-4f4d-ad4f-ab8a247d3150</para>
                    /// </summary>
                    [NameInMap("ScenarioId")]
                    [Validation(Required=false)]
                    public string ScenarioId { get; set; }

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
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
