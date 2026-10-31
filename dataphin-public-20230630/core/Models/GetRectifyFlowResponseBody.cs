// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetRectifyFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The rectification details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRectifyFlowResponseBodyData Data { get; set; }
        public class GetRectifyFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The completion time as a UNIX timestamp in milliseconds. This parameter is empty if the rectification is not completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>57753888419</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The pagination information for rectification issues. If the rectification has been accepted, the acceptance snapshot is used.</para>
            /// </summary>
            [NameInMap("Issues")]
            [Validation(Required=false)]
            public GetRectifyFlowResponseBodyDataIssues Issues { get; set; }
            public class GetRectifyFlowResponseBodyDataIssues : TeaModel {
                /// <summary>
                /// <para>The issues on the current page. The fields are consistent with the issue list.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<GetRectifyFlowResponseBodyDataIssuesData> Data { get; set; }
                public class GetRectifyFlowResponseBodyDataIssuesData : TeaModel {
                    /// <summary>
                    /// <para>The submission time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-10-22</para>
                    /// </summary>
                    [NameInMap("CommitTime")]
                    [Validation(Required=false)]
                    public string CommitTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the governance object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>768244593451</para>
                    /// </summary>
                    [NameInMap("GovernItemId")]
                    [Validation(Required=false)]
                    public long? GovernItemId { get; set; }

                    /// <summary>
                    /// <para>The ID of the governance object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>28783986302</para>
                    /// </summary>
                    [NameInMap("GovernObjectId")]
                    [Validation(Required=false)]
                    public long? GovernObjectId { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the rectification is in progress.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsRectify")]
                    [Validation(Required=false)]
                    public bool? IsRectify { get; set; }

                    /// <summary>
                    /// <para>The list of owners.</para>
                    /// </summary>
                    [NameInMap("Owners")]
                    [Validation(Required=false)]
                    public List<GetRectifyFlowResponseBodyDataIssuesDataOwners> Owners { get; set; }
                    public class GetRectifyFlowResponseBodyDataIssuesDataOwners : TeaModel {
                        /// <summary>
                        /// <para>The display name of the user.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>The ID of the user.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>301</para>
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// <para>The governance issue object.</para>
                    /// </summary>
                    [NameInMap("Problem")]
                    [Validation(Required=false)]
                    public GetRectifyFlowResponseBodyDataIssuesDataProblem Problem { get; set; }
                    public class GetRectifyFlowResponseBodyDataIssuesDataProblem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the object.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("ObjectId")]
                        [Validation(Required=false)]
                        public string ObjectId { get; set; }

                        /// <summary>
                        /// <para>The ID of the parent object.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("ParentObjectId")]
                        [Validation(Required=false)]
                        public string ParentObjectId { get; set; }

                        /// <summary>
                        /// <para>The contact email for the governance issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="mailto:123@test.com">123@test.com</a></para>
                        /// </summary>
                        [NameInMap("ProblemContactMail")]
                        [Validation(Required=false)]
                        public string ProblemContactMail { get; set; }

                        /// <summary>
                        /// <para>Other contact information for the governance issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12345</para>
                        /// </summary>
                        [NameInMap("ProblemContactOther")]
                        [Validation(Required=false)]
                        public string ProblemContactOther { get; set; }

                        /// <summary>
                        /// <para>The contact phone number for the governance issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("ProblemContactPhone")]
                        [Validation(Required=false)]
                        public string ProblemContactPhone { get; set; }

                        /// <summary>
                        /// <para>The description of the governance issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("ProblemDesc")]
                        [Validation(Required=false)]
                        public string ProblemDesc { get; set; }

                        /// <summary>
                        /// <para>The submission method of the issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OPENAPI</para>
                        /// </summary>
                        [NameInMap("ProblemSubmitType")]
                        [Validation(Required=false)]
                        public string ProblemSubmitType { get; set; }

                        /// <summary>
                        /// <para>The user who submitted the issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3001</para>
                        /// </summary>
                        [NameInMap("ProblemSubmitter")]
                        [Validation(Required=false)]
                        public string ProblemSubmitter { get; set; }

                        /// <summary>
                        /// <para>The name of the user who submitted the issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("ProblemSubmitterUserName")]
                        [Validation(Required=false)]
                        public string ProblemSubmitterUserName { get; set; }

                        /// <summary>
                        /// <para>The type of the governance issue.</para>
                        /// </summary>
                        [NameInMap("ProblemTypes")]
                        [Validation(Required=false)]
                        public List<string> ProblemTypes { get; set; }

                    }

                    /// <summary>
                    /// <para>The property map of the governance object.</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Properties { get; set; }

                    /// <summary>
                    /// <para>The ID of the rectification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>813969529153</para>
                    /// </summary>
                    [NameInMap("RectifyId")]
                    [Validation(Required=false)]
                    public long? RectifyId { get; set; }

                    /// <summary>
                    /// <para>The name of the rectification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RectifyName")]
                    [Validation(Required=false)]
                    public string RectifyName { get; set; }

                    /// <summary>
                    /// <para>The status of the rectification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("RectifyStatus")]
                    [Validation(Required=false)]
                    public string RectifyStatus { get; set; }

                    /// <summary>
                    /// <para>The ID of the user who performs the rectification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3001</para>
                    /// </summary>
                    [NameInMap("RectifyUser")]
                    [Validation(Required=false)]
                    public string RectifyUser { get; set; }

                    /// <summary>
                    /// <para>The display name of the user who performs the rectification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RectifyUserName")]
                    [Validation(Required=false)]
                    public string RectifyUserName { get; set; }

                    /// <summary>
                    /// <para>The related knowledge base.</para>
                    /// </summary>
                    [NameInMap("RelatedKnowledge")]
                    [Validation(Required=false)]
                    public List<GetRectifyFlowResponseBodyDataIssuesDataRelatedKnowledge> RelatedKnowledge { get; set; }
                    public class GetRectifyFlowResponseBodyDataIssuesDataRelatedKnowledge : TeaModel {
                        /// <summary>
                        /// <para>The cause of the issue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Cause")]
                        [Validation(Required=false)]
                        public string Cause { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <para>The ID of the knowledge.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>649144693069</para>
                        /// </summary>
                        [NameInMap("KnowledgeId")]
                        [Validation(Required=false)]
                        public long? KnowledgeId { get; set; }

                        /// <summary>
                        /// <para>The owner.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3001</para>
                        /// </summary>
                        [NameInMap("Owner")]
                        [Validation(Required=false)]
                        public string Owner { get; set; }

                        /// <summary>
                        /// <para>The name of the owner.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("OwnerName")]
                        [Validation(Required=false)]
                        public string OwnerName { get; set; }

                        /// <summary>
                        /// <para>The Solutions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>teset</para>
                        /// </summary>
                        [NameInMap("Solution")]
                        [Validation(Required=false)]
                        public string Solution { get; set; }

                        /// <summary>
                        /// <para>The title.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>teset</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// <para>The status of the governance object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The submission method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OPEN API</para>
                    /// </summary>
                    [NameInMap("SubmitType")]
                    [Validation(Required=false)]
                    public string SubmitType { get; set; }

                    /// <summary>
                    /// <para>The tenant ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>575244494646</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public long? TenantId { get; set; }

                }

                /// <summary>
                /// <para>The total number of issues.</para>
                /// 
                /// <b>Example:</b>
                /// <para>467439222172</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The total number of current issues in the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>415492404179</para>
            /// </summary>
            [NameInMap("ProblemCount")]
            [Validation(Required=false)]
            public long? ProblemCount { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14561234364</para>
            /// </summary>
            [NameInMap("RectifyId")]
            [Validation(Required=false)]
            public long? RectifyId { get; set; }

            /// <summary>
            /// <para>The process name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RectifyName")]
            [Validation(Required=false)]
            public string RectifyName { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RectifyPriority")]
            [Validation(Required=false)]
            public string RectifyPriority { get; set; }

            /// <summary>
            /// <para>The rectifier ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3001</para>
            /// </summary>
            [NameInMap("RectifyUser")]
            [Validation(Required=false)]
            public string RectifyUser { get; set; }

            /// <summary>
            /// <para>The rectifier name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RectifyUserName")]
            [Validation(Required=false)]
            public string RectifyUserName { get; set; }

            /// <summary>
            /// <para>The start time, in UNIX milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>496002949493</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The process status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The initiator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3001</para>
            /// </summary>
            [NameInMap("SubmitUser")]
            [Validation(Required=false)]
            public string SubmitUser { get; set; }

            /// <summary>
            /// <para>The initiator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SubmitUserName")]
            [Validation(Required=false)]
            public string SubmitUserName { get; set; }

            /// <summary>
            /// <para>The verifier ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3001</para>
            /// </summary>
            [NameInMap("VerifyUser")]
            [Validation(Required=false)]
            public string VerifyUser { get; set; }

            /// <summary>
            /// <para>The verifier name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VerifyUserName")]
            [Validation(Required=false)]
            public string VerifyUserName { get; set; }

        }

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
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
