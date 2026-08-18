// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class GetCaseDetailResponseBody : TeaModel {
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
        /// <para>The case details data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCaseDetailResponseBodyData Data { get; set; }
        public class GetCaseDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of associated call detail records.</para>
            /// </summary>
            [NameInMap("CallDetailRecords")]
            [Validation(Required=false)]
            public List<GetCaseDetailResponseBodyDataCallDetailRecords> CallDetailRecords { get; set; }
            public class GetCaseDetailResponseBodyDataCallDetailRecords : TeaModel {
                /// <summary>
                /// <para>The access channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2957188c-6cb3-42b4-beca-906fc0e752e5</para>
                /// </summary>
                [NameInMap("AccessChannelId")]
                [Validation(Required=false)]
                public string AccessChannelId { get; set; }

                /// <summary>
                /// <para>The access channel type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("AccessChannelType")]
                [Validation(Required=false)]
                public string AccessChannelType { get; set; }

                /// <summary>
                /// <para>The called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13510595079</para>
                /// </summary>
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                /// <summary>
                /// <para>The caller number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02162300961</para>
                /// </summary>
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

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
                /// <para>Indicates whether the version is a draft version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DraftVersion")]
                [Validation(Required=false)]
                public bool? DraftVersion { get; set; }

                /// <summary>
                /// <para>The total duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The time when the call ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1786960840667</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The party that initiated the hangup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Customer</para>
                /// </summary>
                [NameInMap("ReleaseInitiator")]
                [Validation(Required=false)]
                public string ReleaseInitiator { get; set; }

                /// <summary>
                /// <para>The call session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-893f8715-3658-4488-8cf0-6a8546124f96</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The time when the call started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1786960840667</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The talk time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public long? TalkTime { get; set; }

                /// <summary>
                /// <para>The number of conversation turns.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TalkTurns")]
                [Validation(Required=false)]
                public long? TalkTurns { get; set; }

                /// <summary>
                /// <para>The transfer target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SkillGroup1</para>
                /// </summary>
                [NameInMap("TransferTarget")]
                [Validation(Required=false)]
                public string TransferTarget { get; set; }

                /// <summary>
                /// <para>The transfer type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SkillGroup</para>
                /// </summary>
                [NameInMap("TransferType")]
                [Validation(Required=false)]
                public string TransferType { get; set; }

            }

            /// <summary>
            /// <para>The case information.</para>
            /// </summary>
            [NameInMap("Case")]
            [Validation(Required=false)]
            public GetCaseDetailResponseBodyDataCase Case { get; set; }
            public class GetCaseDetailResponseBodyDataCase : TeaModel {
                /// <summary>
                /// <para>The number of call attempts.</para>
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
                /// <para>0571000018766</para>
                /// </summary>
                [NameInMap("CallerNumber")]
                [Validation(Required=false)]
                public string CallerNumber { get; set; }

                /// <summary>
                /// <para>The ID of the outbound campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5b5c7b4a-978e-4937-a192-02f4621bf67e</para>
                /// </summary>
                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                /// <summary>
                /// <para>The name of the outbound campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test campaign</para>
                /// </summary>
                [NameInMap("CampaignName")]
                [Validation(Required=false)]
                public string CampaignName { get; set; }

                /// <summary>
                /// <para>The case ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>893f8715-3658-4488-8cf0-6a8546124f00</para>
                /// </summary>
                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public string CaseId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-13T06:05:54Z</para>
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
                /// <para>893f8715-3658-4488-8cf0-6a8546124f96</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The list of labels.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<GetCaseDetailResponseBodyDataCaseLabels> Labels { get; set; }
                public class GetCaseDetailResponseBodyDataCaseLabels : TeaModel {
                    /// <summary>
                    /// <para>The set of candidate values for the label.</para>
                    /// </summary>
                    [NameInMap("CandidateValues")]
                    [Validation(Required=false)]
                    public List<string> CandidateValues { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the label was collected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Collected")]
                    [Validation(Required=false)]
                    public bool? Collected { get; set; }

                    /// <summary>
                    /// <para>The label description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The matched value of the label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("MatchedValue")]
                    [Validation(Required=false)]
                    public string MatchedValue { get; set; }

                    /// <summary>
                    /// <para>The label name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Contact customer to register acquaintance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the label is a system label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public bool? System { get; set; }

                }

                /// <summary>
                /// <para>The time of the last call attempt.</para>
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
                /// <para>The priority.</para>
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
                /// <para>1529431297649278976</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>The ringing duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
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
                /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The script name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XiaoHuan</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The session ID of the last call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-893f8715-3658-4488-8cf0-6a8546124f96</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The case state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
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
        /// <para>91102861-AEB9-56C5-8F3A-A023A0E8B5F3</para>
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
