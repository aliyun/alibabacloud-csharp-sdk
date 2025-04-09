// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsWithResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Code</para>
        /// 
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
        public QueryJobsWithResultResponseBodyJobs Jobs { get; set; }
        public class QueryJobsWithResultResponseBodyJobs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryJobsWithResultResponseBodyJobsList> List { get; set; }
            public class QueryJobsWithResultResponseBodyJobsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cc231a1d-3c05-4739-8926-193ecf4097ba</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("JobFailureReason")]
                [Validation(Required=false)]
                public string JobFailureReason { get; set; }

                [NameInMap("LatestTask")]
                [Validation(Required=false)]
                public QueryJobsWithResultResponseBodyJobsListLatestTask LatestTask { get; set; }
                public class QueryJobsWithResultResponseBodyJobsListLatestTask : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40000</para>
                    /// </summary>
                    [NameInMap("CallDuration")]
                    [Validation(Required=false)]
                    public int? CallDuration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("CallDurationDisplay")]
                    [Validation(Required=false)]
                    public string CallDurationDisplay { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1615363297000</para>
                    /// </summary>
                    [NameInMap("CallTime")]
                    [Validation(Required=false)]
                    public long? CallTime { get; set; }

                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public QueryJobsWithResultResponseBodyJobsListLatestTaskContact Contact { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskContact : TeaModel {
                        [NameInMap("Honorific")]
                        [Validation(Required=false)]
                        public string Honorific { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>63860deb-6218-45df-b1e0-76f2b166e790</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cc231a1d-3c05-4739-8926-193ecf4097ba</para>
                        /// </summary>
                        [NameInMap("JobUuid")]
                        [Validation(Required=false)]
                        public string JobUuid { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1882020****</para>
                        /// </summary>
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>134123****</para>
                        /// </summary>
                        [NameInMap("PreferredPhoneNumber")]
                        [Validation(Required=false)]
                        public string PreferredPhoneNumber { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>C01</para>
                        /// </summary>
                        [NameInMap("ReferenceId")]
                        [Validation(Required=false)]
                        public string ReferenceId { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>151</para>
                        /// </summary>
                        [NameInMap("Round")]
                        [Validation(Required=false)]
                        public int? Round { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Available</para>
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                    }

                    [NameInMap("DialExceptionCodes")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskDialExceptionCodes> DialExceptionCodes { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskDialExceptionCodes : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Hint")]
                        [Validation(Required=false)]
                        public string Hint { get; set; }

                    }

                    [NameInMap("Extras")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskExtras> Extras { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskExtras : TeaModel {
                        /// <summary>
                        /// <para>Key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>Value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasAnswered")]
                    [Validation(Required=false)]
                    public bool? HasAnswered { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasHangUpByRejection")]
                    [Validation(Required=false)]
                    public bool? HasHangUpByRejection { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasLastPlaybackCompleted")]
                    [Validation(Required=false)]
                    public bool? HasLastPlaybackCompleted { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasReachedEndOfFlow")]
                    [Validation(Required=false)]
                    public bool? HasReachedEndOfFlow { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Succeeded</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StatusName")]
                    [Validation(Required=false)]
                    public string StatusName { get; set; }

                    [NameInMap("TagHits")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits> TagHits { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits : TeaModel {
                        [NameInMap("TagGroup")]
                        [Validation(Required=false)]
                        public string TagGroup { get; set; }

                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FINISHED</para>
                    /// </summary>
                    [NameInMap("TaskEndReason")]
                    [Validation(Required=false)]
                    public string TaskEndReason { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

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
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

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
        /// <para>9bdaa1d1-a036-4451-ab11-ca0373679091</para>
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

        [NameInMap("VariableNames")]
        [Validation(Required=false)]
        public List<string> VariableNames { get; set; }

    }

}
