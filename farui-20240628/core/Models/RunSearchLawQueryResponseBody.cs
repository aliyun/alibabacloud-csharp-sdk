// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunSearchLawQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RunSearchLawQueryResponseBodyData Data { get; set; }
        public class RunSearchLawQueryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("lawResult")]
            [Validation(Required=false)]
            public List<RunSearchLawQueryResponseBodyDataLawResult> LawResult { get; set; }
            public class RunSearchLawQueryResponseBodyDataLawResult : TeaModel {
                [NameInMap("lawDomain")]
                [Validation(Required=false)]
                public RunSearchLawQueryResponseBodyDataLawResultLawDomain LawDomain { get; set; }
                public class RunSearchLawQueryResponseBodyDataLawResultLawDomain : TeaModel {
                    [NameInMap("abolitionBasis")]
                    [Validation(Required=false)]
                    public string AbolitionBasis { get; set; }

                    [NameInMap("implementYearMonthDate")]
                    [Validation(Required=false)]
                    public string ImplementYearMonthDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("invalidBasis")]
                    [Validation(Required=false)]
                    public string InvalidBasis { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("issuingNo")]
                    [Validation(Required=false)]
                    public string IssuingNo { get; set; }

                    [NameInMap("issuingOrgan")]
                    [Validation(Required=false)]
                    public string IssuingOrgan { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>b2274825c8c3bc2343ca73680243ddc8</para>
                    /// </summary>
                    [NameInMap("lawId")]
                    [Validation(Required=false)]
                    public string LawId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ccc209683be1509676174fd6890f24b8</para>
                    /// </summary>
                    [NameInMap("lawItemId")]
                    [Validation(Required=false)]
                    public string LawItemId { get; set; }

                    [NameInMap("lawName")]
                    [Validation(Required=false)]
                    public string LawName { get; set; }

                    [NameInMap("lawOrder")]
                    [Validation(Required=false)]
                    public string LawOrder { get; set; }

                    [NameInMap("lawSourceContent")]
                    [Validation(Required=false)]
                    public string LawSourceContent { get; set; }

                    [NameInMap("lawTitle")]
                    [Validation(Required=false)]
                    public string LawTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;[]&quot;</para>
                    /// </summary>
                    [NameInMap("modifyBasis")]
                    [Validation(Required=false)]
                    public string ModifyBasis { get; set; }

                    [NameInMap("potencyLevel")]
                    [Validation(Required=false)]
                    public string PotencyLevel { get; set; }

                    [NameInMap("releaseYearMonthDate")]
                    [Validation(Required=false)]
                    public string ReleaseYearMonthDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("thematicClassify")]
                    [Validation(Required=false)]
                    public string ThematicClassify { get; set; }

                    [NameInMap("timeliness")]
                    [Validation(Required=false)]
                    public string Timeliness { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0050</para>
                /// </summary>
                [NameInMap("similarity")]
                [Validation(Required=false)]
                public string Similarity { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            [NameInMap("queryKeywords")]
            [Validation(Required=false)]
            public List<string> QueryKeywords { get; set; }

            [NameInMap("sortKeyAndDirection")]
            [Validation(Required=false)]
            public RunSearchLawQueryResponseBodyDataSortKeyAndDirection SortKeyAndDirection { get; set; }
            public class RunSearchLawQueryResponseBodyDataSortKeyAndDirection : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("releaseYearMonthDate")]
                [Validation(Required=false)]
                public string ReleaseYearMonthDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("similarity")]
                [Validation(Required=false)]
                public string Similarity { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>05062567-EB51-50F6-AF56-0BE44955848D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
