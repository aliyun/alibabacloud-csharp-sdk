// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetUserDeviceWorkloadTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The English name of the workload type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CPU Usage</b>: returned when WorkloadType is set to cpu.</description></item>
        /// <item><description><b>Memory Usage</b>: returned when WorkloadType is set to mem.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPU Usage</para>
        /// </summary>
        [NameInMap("TitleEn")]
        [Validation(Required=false)]
        public string TitleEn { get; set; }

        /// <summary>
        /// <para>The Chinese name of the workload type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CPU使用率</b>: returned when WorkloadType is set to cpu.</description></item>
        /// <item><description><b>内存使用率</b>: returned when WorkloadType is set to mem.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPU 使用率</para>
        /// </summary>
        [NameInMap("TitleZh")]
        [Validation(Required=false)]
        public string TitleZh { get; set; }

        /// <summary>
        /// <para>The list of workload trend data points, sorted by time in ascending order.</para>
        /// </summary>
        [NameInMap("WorkloadList")]
        [Validation(Required=false)]
        public List<GetUserDeviceWorkloadTrendResponseBodyWorkloadList> WorkloadList { get; set; }
        public class GetUserDeviceWorkloadTrendResponseBodyWorkloadList : TeaModel {
            /// <summary>
            /// <para>The collection time of the data point. This value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1755360600</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The workload usage percentage. Valid values: 0 to 100, with two decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35.27</para>
            /// </summary>
            [NameInMap("Workload")]
            [Validation(Required=false)]
            public double? Workload { get; set; }

        }

    }

}
