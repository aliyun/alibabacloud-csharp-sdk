// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListCustomAgentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomAgentResponseBodyData Data { get; set; }
        public class ListCustomAgentResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListCustomAgentResponseBodyDataContent> Content { get; set; }
            public class ListCustomAgentResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16738266********</para>
                /// </summary>
                [NameInMap("AliyunParentId")]
                [Validation(Required=false)]
                public string AliyunParentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20372822********</para>
                /// </summary>
                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HaoY*****</para>
                /// </summary>
                [NameInMap("CreatorUserName")]
                [Validation(Required=false)]
                public string CreatorUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ca-4y3ca4khkcu**********ysf</para>
                /// </summary>
                [NameInMap("CustomAgentId")]
                [Validation(Required=false)]
                public string CustomAgentId { get; set; }

                [NameInMap("DataJson")]
                [Validation(Required=false)]
                public string DataJson { get; set; }

                [NameInMap("DefaultAgent")]
                [Validation(Required=false)]
                public int? DefaultAgent { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("DmsUnit")]
                [Validation(Required=false)]
                public string DmsUnit { get; set; }

                [NameInMap("ExecutionConfig")]
                [Validation(Required=false)]
                public ListCustomAgentResponseBodyDataContentExecutionConfig ExecutionConfig { get; set; }
                public class ListCustomAgentResponseBodyDataContentExecutionConfig : TeaModel {
                    [NameInMap("SkipAskHuman")]
                    [Validation(Required=false)]
                    public bool? SkipAskHuman { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SkipPlan")]
                    [Validation(Required=false)]
                    public bool? SkipPlan { get; set; }

                    [NameInMap("SkipSqlConfirm")]
                    [Validation(Required=false)]
                    public bool? SkipSqlConfirm { get; set; }

                    [NameInMap("SkipWebReportConfirm")]
                    [Validation(Required=false)]
                    public bool? SkipWebReportConfirm { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Instruction")]
                [Validation(Required=false)]
                public string Instruction { get; set; }

                [NameInMap("Knowledge")]
                [Validation(Required=false)]
                public string Knowledge { get; set; }

                [NameInMap("KnowledgeConfigList")]
                [Validation(Required=false)]
                public List<ListCustomAgentResponseBodyDataContentKnowledgeConfigList> KnowledgeConfigList { get; set; }
                public class ListCustomAgentResponseBodyDataContentKnowledgeConfigList : TeaModel {
                    [NameInMap("AccessType")]
                    [Validation(Required=false)]
                    public string AccessType { get; set; }

                    [NameInMap("McpServerId")]
                    [Validation(Required=false)]
                    public string McpServerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20372822********</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HaoY*****</para>
                /// </summary>
                [NameInMap("ModifierUserName")]
                [Validation(Required=false)]
                public string ModifierUserName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("OfflineTime")]
                [Validation(Required=false)]
                public string OfflineTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RELEASED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TextReportConfig")]
                [Validation(Required=false)]
                public string TextReportConfig { get; set; }

                [NameInMap("WebReportConfig")]
                [Validation(Required=false)]
                public string WebReportConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>56kv1pvl9uvt9**********bb</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
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
