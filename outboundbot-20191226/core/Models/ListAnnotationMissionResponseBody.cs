// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionResponseBody : TeaModel {
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
        /// <para>Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnnotationMissionResponseBodyData Data { get; set; }
        public class ListAnnotationMissionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Annotation mission list</para>
            /// </summary>
            [NameInMap("AnnotationMissionList")]
            [Validation(Required=false)]
            public List<ListAnnotationMissionResponseBodyDataAnnotationMissionList> AnnotationMissionList { get; set; }
            public class ListAnnotationMissionResponseBodyDataAnnotationMissionList : TeaModel {
                /// <summary>
                /// <para>Annotation data source type. 1: Outbound call. 2: Navigation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationMissionDataSourceType")]
                [Validation(Required=false)]
                public int? AnnotationMissionDataSourceType { get; set; }

                /// <summary>
                /// <para>Annotation debug data source list</para>
                /// <remarks>
                /// <para>The response includes an extra 0. Valid responses are [0,1], [0,2], or [0,1,2].</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AnnotationMissionDebugDataSourceList")]
                [Validation(Required=false)]
                public List<int?> AnnotationMissionDebugDataSourceList { get; set; }

                /// <summary>
                /// <para>Mission ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                /// </summary>
                [NameInMap("AnnotationMissionId")]
                [Validation(Required=false)]
                public string AnnotationMissionId { get; set; }

                /// <summary>
                /// <para>Mission name</para>
                /// 
                /// <b>Example:</b>
                /// <para>体验场景--移车-标注任务-20230220-141347</para>
                /// </summary>
                [NameInMap("AnnotationMissionName")]
                [Validation(Required=false)]
                public string AnnotationMissionName { get; set; }

                /// <summary>
                /// <para>Annotation status</para>
                /// <list type="bullet">
                /// <item><description><para>1: In progress</para>
                /// </description></item>
                /// <item><description><para>2: Completed</para>
                /// </description></item>
                /// <item><description><para>3: Closed</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationStatus")]
                [Validation(Required=false)]
                public int? AnnotationStatus { get; set; }

                /// <summary>
                /// <para>End time of the conversation time query condition for the annotation mission</para>
                /// 
                /// <b>Example:</b>
                /// <para>1684511999000</para>
                /// </summary>
                [NameInMap("ConversationTimeEndFilter")]
                [Validation(Required=false)]
                public long? ConversationTimeEndFilter { get; set; }

                /// <summary>
                /// <para>Start time of the conversation time query condition for the annotation mission</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683216000000</para>
                /// </summary>
                [NameInMap("ConversationTimeStartFilter")]
                [Validation(Required=false)]
                public long? ConversationTimeStartFilter { get; set; }

                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1676170339515</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether to exclude call records already annotated in other missions</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ExcludeOtherMissionSession")]
                [Validation(Required=false)]
                public bool? ExcludeOtherMissionSession { get; set; }

                /// <summary>
                /// <para>Completion time of the annotation mission</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683443903785</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>Instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>32be9d94-1346-4c4a-a4d0-ccd379f87013</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Maximum sampling count limit</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingCount")]
                [Validation(Required=false)]
                public int? SamplingCount { get; set; }

                /// <summary>
                /// <para>Sampling description</para>
                /// 
                /// <b>Example:</b>
                /// <para>标注</para>
                /// </summary>
                [NameInMap("SamplingDescription")]
                [Validation(Required=false)]
                public string SamplingDescription { get; set; }

                /// <summary>
                /// <para>Sampling rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingRate")]
                [Validation(Required=false)]
                public int? SamplingRate { get; set; }

                /// <summary>
                /// <para>Sampling type</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingType")]
                [Validation(Required=false)]
                public int? SamplingType { get; set; }

                /// <summary>
                /// <para>List of session end reason types used when creating the mission</para>
                /// <list type="bullet">
                /// <item><description><para>1: Normal completion</para>
                /// </description></item>
                /// <item><description><para>2: Bot hangup after rejection</para>
                /// </description></item>
                /// <item><description><para>3: Hangup due to silence timeout</para>
                /// </description></item>
                /// <item><description><para>4: User hangup after rejection</para>
                /// </description></item>
                /// <item><description><para>5: User hangup without reason</para>
                /// </description></item>
                /// <item><description><para>6: Transfer to agent after intent match</para>
                /// </description></item>
                /// <item><description><para>7: Transfer to agent after rejection</para>
                /// </description></item>
                /// <item><description><para>8: No interaction from user side</para>
                /// </description></item>
                /// <item><description><para>9: System exception interruption</para>
                /// </description></item>
                /// <item><description><para>10: Transfer to IVR after intent match</para>
                /// </description></item>
                /// <item><description><para>11: Transfer to IVR after rejection</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("SessionEndReasonFilterList")]
                [Validation(Required=false)]
                public List<int?> SessionEndReasonFilterList { get; set; }

                /// <summary>
                /// <para>Number of completed sessions in the annotation mission</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SessionFinishCount")]
                [Validation(Required=false)]
                public int? SessionFinishCount { get; set; }

                /// <summary>
                /// <para>Total number of sessions in the annotation mission</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SessionTotalCount")]
                [Validation(Required=false)]
                public int? SessionTotalCount { get; set; }

            }

            /// <summary>
            /// <para>Additional information. Returns success for normal requests. Returns a specific error code for abnormal requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDR \&quot;job-c7b8a817-b8e8-40f3-b7ad-f28dcea218ff\&quot; doesn\&quot;t exists.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }

            /// <summary>
            /// <para>Number of entries per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the call succeeded. true: succeeded. false: failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>Total count</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>Total number of pages</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public long? TotalPageCount { get; set; }

        }

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
        /// <para>Additional information. Returns success for normal requests. Returns a specific error code for abnormal requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDR \&quot;job-c7b8a817-b8e8-40f3-b7ad-f28dcea218ff\&quot; doesn\&quot;t exists.</para>
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
        /// <para>Indicates whether the call succeeded. true: succeeded. false: failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
