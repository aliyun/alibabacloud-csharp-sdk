// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the DDoS attack events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeDdosEventResponseBodyEvents> Events { get; set; }
        public class DescribeDdosEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The end time of the attack. The time is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637554335</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>The attacked IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.89.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The traffic volume at the start of the attack. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public int? Mbps { get; set; }

            /// <summary>
            /// <para>The packet rate at the start of the attack. Unit: pps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// <para>The end time of the attack. The time is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637554034</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>The current status of the attack event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>hole_begin</b>: Indicates that the attacked IP address is in the blackhole filtering status.</description></item>
            /// <item><description><b>hole_end</b>: Indicates that the attacked IP address is removed from the blackhole filtering status.</description></item>
            /// <item><description><b>defense_begin</b>: Indicates that the system scrubs traffic.</description></item>
            /// <item><description><b>defense_end</b>: Indicates that the attack ends and the system scrubs traffic no more.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3B6C3F9-6B21-519D-B976-A1E14166F909</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of DDoS attack events returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
