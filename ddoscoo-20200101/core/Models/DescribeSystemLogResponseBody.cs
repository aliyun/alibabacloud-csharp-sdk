// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSystemLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BC3A33A-F832-58DB-952F-7682A25AD14C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the billing logs for burstable clean bandwidth.</para>
        /// </summary>
        [NameInMap("SystemLog")]
        [Validation(Required=false)]
        public List<DescribeSystemLogResponseBodySystemLog> SystemLog { get; set; }
        public class DescribeSystemLogResponseBodySystemLog : TeaModel {
            /// <summary>
            /// <para>The IP address of the Anti-DDoS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.XX.XX</para>
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// <para>The type of the system log. The value is fixed at <b>20</b>, which indicates the billing log of burstable clean bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <para>The time when the bill was created. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631793531000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the bill was last modified. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635425407000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the bill belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171986973287****</para>
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// <para>The operation type. The value is fixed at <b>100</b>, which indicates that a billing record for burstable clean bandwidth is added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// <para>The details of the bill. This value is a string that is converted from a JSON struct. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>newEntity</b>: Object type, which indicates the bill record and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>billValue</b>: Integer type | The usage of burstable clean bandwidth in the billing month. Unit: Mbit/s.</description></item>
            /// <item><description><b>instanceId</b>: String type | The ID of the Anti-DDoS instance.</description></item>
            /// <item><description><b>ip</b>: String type | The IP address of the Anti-DDoS instance.</description></item>
            /// <item><description><b>maxBw</b>: String type | The actual peak value of service traffic in the billing month (monthly 95th percentile). Unit: Mbit/s.</description></item>
            /// <item><description><b>month</b>: Long type | The month when the bill is generated (the billing month is the calendar month before the month when the bill is generated). This value is a timestamp in milliseconds.</description></item>
            /// <item><description><b>overBandwidth</b>: Integer type | The bandwidth that exceeds the clean bandwidth specification of the instance. Unit: Mbit/s.</description></item>
            /// <item><description><b>peakTime</b>: Long type | The time when the actual peak value of service traffic is measured. This value is a timestamp in seconds.</description></item>
            /// <item><description><b>startTimestamp</b>: Long type | The start time of the period when the peak value of instance service traffic is measured. This value is a timestamp in seconds.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;newEntity&quot;:{&quot;billValue&quot;:&quot;60&quot;,&quot;instanceId&quot;:&quot;ddoscoo-cn-zz121ogz****&quot;,&quot;ip&quot;:&quot;203.107.XX.XX&quot;,&quot;maxBw&quot;:&quot;300&quot;,&quot;month&quot;:1627747200000,&quot;overBandwidth&quot;:&quot;120&quot;,&quot;peakTime&quot;:1629871200,&quot;startTimestamp&quot;:1629871200}}</para>
            /// </summary>
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

            /// <summary>
            /// <para>The status of the bill. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: indicates that the bill is pending.</description></item>
            /// <item><description><b>1</b>: indicates that the bill is generated.</description></item>
            /// <item><description><b>2</b>: indicates that the bill is terminated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of billing logs for burstable clean bandwidth that are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
