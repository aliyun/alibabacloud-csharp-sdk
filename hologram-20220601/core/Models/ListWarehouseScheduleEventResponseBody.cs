// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListWarehouseScheduleEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<ListWarehouseScheduleEventResponseBodyEventList> EventList { get; set; }
        public class ListWarehouseScheduleEventResponseBodyEventList : TeaModel {
            /// <summary>
            /// <para>The number of clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public long? ClusterCount { get; set; }

            /// <summary>
            /// <para>The cluster specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("ClusterCpu")]
            [Validation(Required=false)]
            public long? ClusterCpu { get; set; }

            /// <summary>
            /// <para>The number of elastic CPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("ElasticCpu")]
            [Validation(Required=false)]
            public long? ElasticCpu { get; set; }

            /// <summary>
            /// <para>The elastic scaling type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScaleUp</para>
            /// </summary>
            [NameInMap("ElasticType")]
            [Validation(Required=false)]
            public string ElasticType { get; set; }

            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AlterWarehouse</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The time when the event occurred (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-22T09:43:02.638Z</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// <para>The reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>insufficient resource</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The number of reserved clusters, which refers to non-elastic clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InitClusterCount")]
            [Validation(Required=false)]
            public long? InitClusterCount { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OriginalElasticCpu")]
            [Validation(Required=false)]
            public long? OriginalElasticCpu { get; set; }

            /// <summary>
            /// <para>The number of reserved CPUs, which refers to non-elastic CPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("ReservedCpu")]
            [Validation(Required=false)]
            public long? ReservedCpu { get; set; }

            /// <summary>
            /// <para>The result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The name of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>init_warehouse</para>
            /// </summary>
            [NameInMap("WarehouseName")]
            [Validation(Required=false)]
            public string WarehouseName { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 30. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>E16D32D4-DF86-1180-8220-0D39770A5AF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
