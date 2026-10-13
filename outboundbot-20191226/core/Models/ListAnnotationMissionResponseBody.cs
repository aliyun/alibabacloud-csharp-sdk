// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnnotationMissionResponseBodyData Data { get; set; }
        public class ListAnnotationMissionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of annotation tasks.</para>
            /// </summary>
            [NameInMap("AnnotationMissionList")]
            [Validation(Required=false)]
            public List<ListAnnotationMissionResponseBodyDataAnnotationMissionList> AnnotationMissionList { get; set; }
            public class ListAnnotationMissionResponseBodyDataAnnotationMissionList : TeaModel {
                /// <summary>
                /// <para>The data source of the annotation task. Valid values: 1: Outbound call. 2: Navigation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationMissionDataSourceType")]
                [Validation(Required=false)]
                public int? AnnotationMissionDataSourceType { get; set; }

                /// <summary>
                /// <para>The list of debug data sources for the annotation task.</para>
                /// <remarks>
                /// <para>Note: An additional 0 is included in the response. The return values are [0,1], [0,2], or [0,1,2].</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AnnotationMissionDebugDataSourceList")]
                [Validation(Required=false)]
                public List<int?> AnnotationMissionDebugDataSourceList { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                /// </summary>
                [NameInMap("AnnotationMissionId")]
                [Validation(Required=false)]
                public string AnnotationMissionId { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Experience scenario - Move vehicle - Annotation task - 20230220-141347</para>
                /// </summary>
                [NameInMap("AnnotationMissionName")]
                [Validation(Required=false)]
                public string AnnotationMissionName { get; set; }

                /// <summary>
                /// <para>The annotation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: In progress.</description></item>
                /// <item><description>2: Completed.</description></item>
                /// <item><description>3: Closed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationStatus")]
                [Validation(Required=false)]
                public int? AnnotationStatus { get; set; }

                /// <summary>
                /// <para>The end time of the conversation time query condition for the annotation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1684511999000</para>
                /// </summary>
                [NameInMap("ConversationTimeEndFilter")]
                [Validation(Required=false)]
                public long? ConversationTimeEndFilter { get; set; }

                /// <summary>
                /// <para>The start time of the conversation time query condition for the annotation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683216000000</para>
                /// </summary>
                [NameInMap("ConversationTimeStartFilter")]
                [Validation(Required=false)]
                public long? ConversationTimeStartFilter { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1676170339515</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether to exclude call records that have been annotated in other tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ExcludeOtherMissionSession")]
                [Validation(Required=false)]
                public bool? ExcludeOtherMissionSession { get; set; }

                /// <summary>
                /// <para>The completion time of the annotation task. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683443903785</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32be9d94-1346-4c4a-a4d0-ccd379f87013</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum limit for the sampling count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingCount")]
                [Validation(Required=false)]
                public int? SamplingCount { get; set; }

                /// <summary>
                /// <para>The sampling description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Annotation</para>
                /// </summary>
                [NameInMap("SamplingDescription")]
                [Validation(Required=false)]
                public string SamplingDescription { get; set; }

                /// <summary>
                /// <para>The sampling rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingRate")]
                [Validation(Required=false)]
                public int? SamplingRate { get; set; }

                /// <summary>
                /// <para>The sampling type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingType")]
                [Validation(Required=false)]
                public int? SamplingType { get; set; }

                /// <summary>
                /// <para>The list of call end reasons used to create the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Normal completion.</description></item>
                /// <item><description>2: Hang up by the robot after unrecognized input.</description></item>
                /// <item><description>3: Hang up due to silence timeout.</description></item>
                /// <item><description>4: Hang up by the user after unrecognized input.</description></item>
                /// <item><description>5: Hang up by the user without a reason.</description></item>
                /// <item><description>6: Transfer to a human agent due to intent match.</description></item>
                /// <item><description>7: Transfer to a human agent after unrecognized input.</description></item>
                /// <item><description>8: No interaction on the user side.</description></item>
                /// <item><description>9: Interruption due to a system exception.</description></item>
                /// <item><description>10: Transfer to IVR due to intent match.</description></item>
                /// <item><description>11: Transfer to IVR after unrecognized input.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SessionEndReasonFilterList")]
                [Validation(Required=false)]
                public List<int?> SessionEndReasonFilterList { get; set; }

                /// <summary>
                /// <para>The number of completed sessions in the annotation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SessionFinishCount")]
                [Validation(Required=false)]
                public int? SessionFinishCount { get; set; }

                /// <summary>
                /// <para>The total number of sessions in the annotation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SessionTotalCount")]
                [Validation(Required=false)]
                public int? SessionTotalCount { get; set; }

            }

            /// <summary>
            /// <para>The additional information. If the request is successful, success is returned. If the request fails, a specific error code is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDR \&quot;job-c7b8a817-b8e8-40f3-b7ad-f28dcea218ff\&quot; doesn\&quot;t exists.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the call was successful. Valid values: true: The call was successful. false: The call failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public long? TotalPageCount { get; set; }

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
        /// <para>The additional information. If the request is successful, success is returned. If the request fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDR \&quot;job-c7b8a817-b8e8-40f3-b7ad-f28dcea218ff\&quot; doesn\&quot;t exists.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values: true: The call was successful. false: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
