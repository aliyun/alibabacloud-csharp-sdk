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
        /// <para>An array that consists of details of the billing logs for the burstable clean bandwidth.</para>
        /// </summary>
        [NameInMap("SystemLog")]
        [Validation(Required=false)]
        public List<DescribeSystemLogResponseBodySystemLog> SystemLog { get; set; }
        public class DescribeSystemLogResponseBodySystemLog : TeaModel {
            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.XX.XX</para>
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// <para>The type of the system log. The value is fixed as <b>20</b>, which indicates the billing logs for burstable clean bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// <para>The time when the bill was generated. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631793531000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the bill was last modified. The value is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <para>The operation type. The value is fixed as <b>100</b>, which indicates the billing logs for the burstable clean bandwidth that you increased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// <para>The details of the bill. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>newEntity</b>: the bill record, which contains the following fields. Data type: object.</para>
            /// <list type="bullet">
            /// <item><description><b>billValue</b>: the usage of the burstable clean bandwidth within a month. Unit: Mbit/s. Data type: integer.</description></item>
            /// <item><description><b>instanceId</b>: the ID of the instance. Data type: string.</description></item>
            /// <item><description><b>ip</b>: the IP address of the instance. Data type: string.</description></item>
            /// <item><description><b>maxBw</b>: the peak service traffic (monthly 95th percentile bandwidth) within a month. Unit: Mbit/s. Data type: string.</description></item>
            /// <item><description><b>month</b>: the month in which the bill of the previous calendar month is issued. This value is a UNIX timestamp. Unit: milliseconds. Data type: long.</description></item>
            /// <item><description><b>overBandwidth</b>: the peak service traffic minus the clean bandwidth of the instance. Unit: Mbit/s. Data type: integer.</description></item>
            /// <item><description><b>peakTime</b>: the time in point of the peak service traffic that is measured for billing. This value is a UNIX timestamp. Unit: seconds. Data type: long.</description></item>
            /// <item><description><b>startTimestamp</b>: the beginning of the time range for the peak service traffic range. This value is a UNIX timestamp. Unit: seconds. Data type: long.</description></item>
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
            /// <item><description><b>0</b>: to be billed</description></item>
            /// <item><description><b>1</b>: billed</description></item>
            /// <item><description><b>2</b>: terminated</description></item>
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
        /// <para>The total number of billing logs for the burstable clean bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
