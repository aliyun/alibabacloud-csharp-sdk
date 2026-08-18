// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListCasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paged data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCasesResponseBodyData Data { get; set; }
        public class ListCasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of cases.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCasesResponseBodyDataList> List { get; set; }
            public class ListCasesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The number of dial attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AttemptedCount")]
                [Validation(Required=false)]
                public int? AttemptedCount { get; set; }

                /// <summary>
                /// <para>The caller number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05923395478</para>
                /// </summary>
                [NameInMap("CallerNumber")]
                [Validation(Required=false)]
                public string CallerNumber { get; set; }

                /// <summary>
                /// <para>The outbound campaign ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7607dae1-91ad-47ea-ad76-3d81ac34f729</para>
                /// </summary>
                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                /// <summary>
                /// <para>The name of the outbound campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e2d7a184-7d6c-45d4-ac24-34ab48f54600</para>
                /// </summary>
                [NameInMap("CampaignName")]
                [Validation(Required=false)]
                public string CampaignName { get; set; }

                /// <summary>
                /// <para>The case ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00ed0dd9-c5a4-40e4-a8cd-822f0af859b9</para>
                /// </summary>
                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public string CaseId { get; set; }

                /// <summary>
                /// <para>The time when the case was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-27T11:25:15+08:00</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The custom variables in JSON string format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("CustomVariables")]
                [Validation(Required=false)]
                public string CustomVariables { get; set; }

                /// <summary>
                /// <para>The dialing time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1786960840667</para>
                /// </summary>
                [NameInMap("DialingTime")]
                [Validation(Required=false)]
                public long? DialingTime { get; set; }

                /// <summary>
                /// <para>The disposition code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Answered</para>
                /// </summary>
                [NameInMap("DispositionCode")]
                [Validation(Required=false)]
                public string DispositionCode { get; set; }

                /// <summary>
                /// <para>The disposition reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("DispositionReason")]
                [Validation(Required=false)]
                public string DispositionReason { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e2d7a184-7d6c-45d4-ac24-34ab48f54669</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The list of labels.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<ListCasesResponseBodyDataListLabels> Labels { get; set; }
                public class ListCasesResponseBodyDataListLabels : TeaModel {
                    /// <summary>
                    /// <para>The candidate values of the label.</para>
                    /// </summary>
                    [NameInMap("CandidateValues")]
                    [Validation(Required=false)]
                    public List<string> CandidateValues { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the item is collected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Collected")]
                    [Validation(Required=false)]
                    public bool? Collected { get; set; }

                    /// <summary>
                    /// <para>The description of the label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Description content</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The matched value of the label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MatchedValue")]
                    [Validation(Required=false)]
                    public string MatchedValue { get; set; }

                    /// <summary>
                    /// <para>The name of the label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>软包装企业打电话_20251022_165548</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The system label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public bool? System { get; set; }

                }

                /// <summary>
                /// <para>The time of the last dial attempt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1786960840667</para>
                /// </summary>
                [NameInMap("LastAttemptedTime")]
                [Validation(Required=false)]
                public long? LastAttemptedTime { get; set; }

                /// <summary>
                /// <para>The called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18512345678</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>The priority of the case.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Daily</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The reference ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5055-16-199313</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>The ringing duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("RingingDuration")]
                [Validation(Required=false)]
                public long? RingingDuration { get; set; }

                /// <summary>
                /// <para>The ringing time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1786960840667</para>
                /// </summary>
                [NameInMap("RingingTime")]
                [Validation(Required=false)]
                public long? RingingTime { get; set; }

                /// <summary>
                /// <para>The script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8a988bd4-6c6e-45c6-b3a5-3def5ca3bc6f</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The name of the script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scenario Name</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The session ID of the last call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_ID_312986372_7295954260941888</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The case state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The talk time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public long? TalkTime { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pass-through parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C377C5FF-4F94-1B23-89D0-50C560623EE4</para>
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
