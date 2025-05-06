// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunSearchCaseFullTextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RunSearchCaseFullTextResponseBodyData Data { get; set; }
        public class RunSearchCaseFullTextResponseBodyData : TeaModel {
            [NameInMap("caseLevel")]
            [Validation(Required=false)]
            public string CaseLevel { get; set; }

            [NameInMap("caseResult")]
            [Validation(Required=false)]
            public List<RunSearchCaseFullTextResponseBodyDataCaseResult> CaseResult { get; set; }
            public class RunSearchCaseFullTextResponseBodyDataCaseResult : TeaModel {
                [NameInMap("caseDomain")]
                [Validation(Required=false)]
                public RunSearchCaseFullTextResponseBodyDataCaseResultCaseDomain CaseDomain { get; set; }
                public class RunSearchCaseFullTextResponseBodyDataCaseResultCaseDomain : TeaModel {
                    [NameInMap("abstractObj")]
                    [Validation(Required=false)]
                    public string AbstractObj { get; set; }

                    [NameInMap("appliedLaws")]
                    [Validation(Required=false)]
                    public string AppliedLaws { get; set; }

                    [NameInMap("basicCase")]
                    [Validation(Required=false)]
                    public string BasicCase { get; set; }

                    [NameInMap("caseBasic")]
                    [Validation(Required=false)]
                    public string CaseBasic { get; set; }

                    [NameInMap("caseCause")]
                    [Validation(Required=false)]
                    public string CaseCause { get; set; }

                    [NameInMap("caseFeature")]
                    [Validation(Required=false)]
                    public string CaseFeature { get; set; }

                    [NameInMap("caseId")]
                    [Validation(Required=false)]
                    public string CaseId { get; set; }

                    [NameInMap("caseNo")]
                    [Validation(Required=false)]
                    public string CaseNo { get; set; }

                    [NameInMap("caseSummary")]
                    [Validation(Required=false)]
                    public string CaseSummary { get; set; }

                    [NameInMap("caseTitle")]
                    [Validation(Required=false)]
                    public string CaseTitle { get; set; }

                    [NameInMap("caseType")]
                    [Validation(Required=false)]
                    public string CaseType { get; set; }

                    [NameInMap("closeCaseCause")]
                    [Validation(Required=false)]
                    public string CloseCaseCause { get; set; }

                    [NameInMap("courtFindOut")]
                    [Validation(Required=false)]
                    public string CourtFindOut { get; set; }

                    [NameInMap("courtThink")]
                    [Validation(Required=false)]
                    public string CourtThink { get; set; }

                    [NameInMap("dataFrom")]
                    [Validation(Required=false)]
                    public string DataFrom { get; set; }

                    [NameInMap("disputeFocus")]
                    [Validation(Required=false)]
                    public string DisputeFocus { get; set; }

                    [NameInMap("disputeFocusTag")]
                    [Validation(Required=false)]
                    public List<string> DisputeFocusTag { get; set; }

                    [NameInMap("disputedpoints")]
                    [Validation(Required=false)]
                    public string Disputedpoints { get; set; }

                    [NameInMap("documentType")]
                    [Validation(Required=false)]
                    public string DocumentType { get; set; }

                    [NameInMap("judgReason")]
                    [Validation(Required=false)]
                    public string JudgReason { get; set; }

                    [NameInMap("keyfacts")]
                    [Validation(Required=false)]
                    public string Keyfacts { get; set; }

                    [NameInMap("legalBasis")]
                    [Validation(Required=false)]
                    public string LegalBasis { get; set; }

                    [NameInMap("litigants")]
                    [Validation(Required=false)]
                    public string Litigants { get; set; }

                    [NameInMap("litigationParticipant")]
                    [Validation(Required=false)]
                    public string LitigationParticipant { get; set; }

                    [NameInMap("openCaseCause")]
                    [Validation(Required=false)]
                    public string OpenCaseCause { get; set; }

                    [NameInMap("preTrialProcess")]
                    [Validation(Required=false)]
                    public string PreTrialProcess { get; set; }

                    [NameInMap("referLevel")]
                    [Validation(Required=false)]
                    public string ReferLevel { get; set; }

                    [NameInMap("refereeGist")]
                    [Validation(Required=false)]
                    public string RefereeGist { get; set; }

                    [NameInMap("sourceContent")]
                    [Validation(Required=false)]
                    public string SourceContent { get; set; }

                    [NameInMap("trialCourt")]
                    [Validation(Required=false)]
                    public RunSearchCaseFullTextResponseBodyDataCaseResultCaseDomainTrialCourt TrialCourt { get; set; }
                    public class RunSearchCaseFullTextResponseBodyDataCaseResultCaseDomainTrialCourt : TeaModel {
                        [NameInMap("city")]
                        [Validation(Required=false)]
                        public string City { get; set; }

                        [NameInMap("commonLevel")]
                        [Validation(Required=false)]
                        public string CommonLevel { get; set; }

                        [NameInMap("country")]
                        [Validation(Required=false)]
                        public string Country { get; set; }

                        [NameInMap("county")]
                        [Validation(Required=false)]
                        public string County { get; set; }

                        [NameInMap("district")]
                        [Validation(Required=false)]
                        public string District { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("province")]
                        [Validation(Required=false)]
                        public string Province { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>“”</para>
                        /// </summary>
                        [NameInMap("specialLevel")]
                        [Validation(Required=false)]
                        public string SpecialLevel { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2018-09-27</para>
                    /// </summary>
                    [NameInMap("trialDate")]
                    [Validation(Required=false)]
                    public string TrialDate { get; set; }

                    [NameInMap("trialLevel")]
                    [Validation(Required=false)]
                    public string TrialLevel { get; set; }

                    [NameInMap("trialProcess")]
                    [Validation(Required=false)]
                    public string TrialProcess { get; set; }

                    [NameInMap("trialProgram")]
                    [Validation(Required=false)]
                    public string TrialProgram { get; set; }

                    [NameInMap("verdict")]
                    [Validation(Required=false)]
                    public string Verdict { get; set; }

                }

                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.88</para>
                /// </summary>
                [NameInMap("similarity")]
                [Validation(Required=false)]
                public string Similarity { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <para>C844BE6B-33A9-5AC4-A1AE-97B131849E0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
