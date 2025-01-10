// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVccFlowInfosRequest : TeaModel {
        /// <summary>
        /// <para>Direction</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>IN: inbound.</description></item>
        /// <item><description>OUT: the outbound.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OUT</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The start time. The default value is 5 minutes ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1667727514000</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>Metric</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>totalPacketsRate: Total Packet Rate.</description></item>
        /// <item><description>dropBytesRate: the of the stream drop rate.</description></item>
        /// <item><description>dropPacketsRate: Dropped Packet Rate.</description></item>
        /// <item><description>totalBytesRate: the total streaming rate.</description></item>
        /// <item><description>passBytesRate: by stream rate.</description></item>
        /// <item><description>passPacketsRate: by packet rate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>passBytesRate</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The end time. The default time is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1689749749000</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

        /// <summary>
        /// <para>Lingjun Connection ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-zvp2******</para>
        /// </summary>
        [NameInMap("VccId")]
        [Validation(Required=false)]
        public string VccId { get; set; }

    }

}
