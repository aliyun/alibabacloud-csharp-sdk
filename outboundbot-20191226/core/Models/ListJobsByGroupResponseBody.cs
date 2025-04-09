// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobsByGroupResponseBody : TeaModel {
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
        public ListJobsByGroupResponseBodyJobs Jobs { get; set; }
        public class ListJobsByGroupResponseBodyJobs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListJobsByGroupResponseBodyJobsList> List { get; set; }
            public class ListJobsByGroupResponseBodyJobsList : TeaModel {
                [NameInMap("CallingNumbers")]
                [Validation(Required=false)]
                public List<string> CallingNumbers { get; set; }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<ListJobsByGroupResponseBodyJobsListContacts> Contacts { get; set; }
                public class ListJobsByGroupResponseBodyJobsListContacts : TeaModel {
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
                public List<ListJobsByGroupResponseBodyJobsListExtras> Extras { get; set; }
                public class ListJobsByGroupResponseBodyJobsListExtras : TeaModel {
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
                /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

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
                public List<ListJobsByGroupResponseBodyJobsListSummary> Summary { get; set; }
                public class ListJobsByGroupResponseBodyJobsListSummary : TeaModel {
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
                    /// <para>62a860f5-a8b3-4b75-9512-c7e04bb7c8bc</para>
                    /// </summary>
                    [NameInMap("ConversationDetailId")]
                    [Validation(Required=false)]
                    public string ConversationDetailId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>88e56cfb-33f8-477a-907c-0fe83292d924</para>
                    /// </summary>
                    [NameInMap("JobGroupId")]
                    [Validation(Required=false)]
                    public string JobGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>f102a853-5f5a-47fb-8869-b31ea74a9620</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>680f1905-81ae-4aab-99dd-2964dfb767fa</para>
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
                    /// <para>b0f35dd1-0337-402e-9c4f-3a6c2426950a</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SystemPriority")]
                [Validation(Required=false)]
                public int? SystemPriority { get; set; }

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
