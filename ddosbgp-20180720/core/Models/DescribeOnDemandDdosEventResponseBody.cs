// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandDdosEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the DDoS attack event.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeOnDemandDdosEventResponseBodyEvents> Events { get; set; }
        public class DescribeOnDemandDdosEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The time when the DDoS attack stopped. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1557891306</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>The attacked IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The attack traffic. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public int? Mbps { get; set; }

            /// <summary>
            /// <para>The packet forwarding rate of the DDoS attack. Unit: packets per second (PPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// <para>The time when the DDoS attack started. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1557889506</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the DDoS attack event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>hole_begin</b>: indicates that blackhole filtering is triggered.</description></item>
            /// <item><description><b>hole_end</b>: indicates that tblackhole filtering is deactivated.</description></item>
            /// <item><description><b>defense_begin</b>: indicates that traffic scrubbing is in progress.</description></item>
            /// <item><description><b>defense_end</b>: indicates that traffic scrubbing is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>defense_end</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A507DC8-F657-4C13-84E2-D1D1B9400753</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of DDoS attack events that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
