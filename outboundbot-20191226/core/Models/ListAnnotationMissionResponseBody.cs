// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnnotationMissionResponseBodyData Data { get; set; }
        public class ListAnnotationMissionResponseBodyData : TeaModel {
            [NameInMap("AnnotationMissionList")]
            [Validation(Required=false)]
            public List<ListAnnotationMissionResponseBodyDataAnnotationMissionList> AnnotationMissionList { get; set; }
            public class ListAnnotationMissionResponseBodyDataAnnotationMissionList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationMissionDataSourceType")]
                [Validation(Required=false)]
                public int? AnnotationMissionDataSourceType { get; set; }

                [NameInMap("AnnotationMissionDebugDataSourceList")]
                [Validation(Required=false)]
                public List<int?> AnnotationMissionDebugDataSourceList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                /// </summary>
                [NameInMap("AnnotationMissionId")]
                [Validation(Required=false)]
                public string AnnotationMissionId { get; set; }

                [NameInMap("AnnotationMissionName")]
                [Validation(Required=false)]
                public string AnnotationMissionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationStatus")]
                [Validation(Required=false)]
                public int? AnnotationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1684511999000</para>
                /// </summary>
                [NameInMap("ConversationTimeEndFilter")]
                [Validation(Required=false)]
                public long? ConversationTimeEndFilter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1683216000000</para>
                /// </summary>
                [NameInMap("ConversationTimeStartFilter")]
                [Validation(Required=false)]
                public long? ConversationTimeStartFilter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1676170339515</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ExcludeOtherMissionSession")]
                [Validation(Required=false)]
                public bool? ExcludeOtherMissionSession { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1683443903785</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32be9d94-1346-4c4a-a4d0-ccd379f87013</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingCount")]
                [Validation(Required=false)]
                public int? SamplingCount { get; set; }

                [NameInMap("SamplingDescription")]
                [Validation(Required=false)]
                public string SamplingDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingRate")]
                [Validation(Required=false)]
                public int? SamplingRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingType")]
                [Validation(Required=false)]
                public int? SamplingType { get; set; }

                [NameInMap("SessionEndReasonFilterList")]
                [Validation(Required=false)]
                public List<int?> SessionEndReasonFilterList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SessionFinishCount")]
                [Validation(Required=false)]
                public int? SessionFinishCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SessionTotalCount")]
                [Validation(Required=false)]
                public int? SessionTotalCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CDR \&quot;job-c7b8a817-b8e8-40f3-b7ad-f28dcea218ff\&quot; doesn\&quot;t exists.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public long? TotalPageCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CDR \&quot;job-c7b8a817-b8e8-40f3-b7ad-f28dcea218ff\&quot; doesn\&quot;t exists.</para>
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
