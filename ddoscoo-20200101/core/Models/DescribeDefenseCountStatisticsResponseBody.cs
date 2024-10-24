// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDefenseCountStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics on the number of advanced mitigation sessions.</para>
        /// </summary>
        [NameInMap("DefenseCountStatistics")]
        [Validation(Required=false)]
        public DescribeDefenseCountStatisticsResponseBodyDefenseCountStatistics DefenseCountStatistics { get; set; }
        public class DescribeDefenseCountStatisticsResponseBodyDefenseCountStatistics : TeaModel {
            /// <summary>
            /// <para>The number of advanced mitigation sessions that are used within the current calendar month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DefenseCountTotalUsageOfCurrentMonth")]
            [Validation(Required=false)]
            public int? DefenseCountTotalUsageOfCurrentMonth { get; set; }

            /// <summary>
            /// <para>The number of available global advanced mitigation sessions for the Insurance mitigation plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FlowPackCountRemain")]
            [Validation(Required=false)]
            public int? FlowPackCountRemain { get; set; }

            /// <summary>
            /// <para>The maximum number of advanced mitigation sessions available for the current calendar month. The advanced mitigation sessions include the advanced mitigation sessions that are provided free of charge and the global advanced mitigation sessions that you purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxUsableDefenseCountCurrentMonth")]
            [Validation(Required=false)]
            public int? MaxUsableDefenseCountCurrentMonth { get; set; }

            /// <summary>
            /// <para>The number of available global advanced mitigation sessions for the Secure Chinese Mainland Acceleration (Sec-CMA) mitigation plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecHighSpeedCountRemain")]
            [Validation(Required=false)]
            public int? SecHighSpeedCountRemain { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>310A41FD-0990-5610-92E0-A6A55D7C6444</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
