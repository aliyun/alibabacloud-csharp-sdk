// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListWarehouseScheduleTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A0A16C46-5B56-1F9B-AA37-4C3EAD95AAA8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScheduleTaskList")]
        [Validation(Required=false)]
        public List<ListWarehouseScheduleTaskResponseBodyScheduleTaskList> ScheduleTaskList { get; set; }
        public class ListWarehouseScheduleTaskResponseBodyScheduleTaskList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>timed</para>
            /// </summary>
            [NameInMap("ElasticType")]
            [Validation(Required=false)]
            public string ElasticType { get; set; }

            [NameInMap("Plans")]
            [Validation(Required=false)]
            public List<ListWarehouseScheduleTaskResponseBodyScheduleTaskListPlans> Plans { get; set; }
            public class ListWarehouseScheduleTaskResponseBodyScheduleTaskListPlans : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>bill stat</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("ElasticCu")]
                [Validation(Required=false)]
                public long? ElasticCu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0400</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1802985780260052993</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0100</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("ReservedCpu")]
            [Validation(Required=false)]
            public long? ReservedCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kRunning</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WarehouseId")]
            [Validation(Required=false)]
            public string WarehouseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>init_warehouse</para>
            /// </summary>
            [NameInMap("WarehouseName")]
            [Validation(Required=false)]
            public string WarehouseName { get; set; }

        }

    }

}
