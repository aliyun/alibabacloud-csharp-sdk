// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed alert statistics of container assets.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContainerStatisticsResponseBodyData Data { get; set; }
        public class DescribeContainerStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of alerts with the <b>Reminder</b> risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemindAlarmCount")]
            [Validation(Required=false)]
            public int? RemindAlarmCount { get; set; }

            /// <summary>
            /// <para>The number of alerts with the <b>Urgent</b> risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SeriousAlarmCount")]
            [Validation(Required=false)]
            public int? SeriousAlarmCount { get; set; }

            /// <summary>
            /// <para>The number of alerts with the <b>Suspicious</b> risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SuspiciousAlarmCount")]
            [Validation(Required=false)]
            public int? SuspiciousAlarmCount { get; set; }

            /// <summary>
            /// <para>The total number of security alerts in the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TotalAlarmCount")]
            [Validation(Required=false)]
            public int? TotalAlarmCount { get; set; }

            /// <summary>
            /// <para>The total number of nodes in the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalNode")]
            [Validation(Required=false)]
            public int? TotalNode { get; set; }

            /// <summary>
            /// <para>The number of nodes that have alerts in the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("hasRiskNode")]
            [Validation(Required=false)]
            public int? HasRiskNode { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request, which can be used for troubleshooting and diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21DA46CA-2DCE-4FF6-907D-D5DBBB7518C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
