// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the renewed secure DCDN takes effect. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// <para>The new metering method for the renewed secure DCDN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay by data transfer</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay by bandwidth</description></item>
        /// <item><description><b>PayByBandwidth95</b>: pay by 95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_monthavg</b>: pay by monthly average bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_month4th</b>: pay by fourth peak bandwidth per month</description></item>
        /// <item><description><b>PayByBandwidth_monthday95avg</b>: pay by monthly average 95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_nighthalf95</b>: pay by 95th percentile bandwidth (50% off during nighttime)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FP-mkqgwxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The current metering method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay by data transfer</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay by bandwidth</description></item>
        /// <item><description><b>PayByBandwidth95</b>: pay by 95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_monthavg</b>: pay by monthly average bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_month4th</b>: pay by fourth peak bandwidth per month</description></item>
        /// <item><description><b>PayByBandwidth_monthday95avg</b>: pay by monthly average 95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_nighthalf95</b>: pay by 95th percentile bandwidth (50% off during nighttime)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The time when the DCDN service was activated. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-19T11:16:11Z</para>
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// <para>The lock status of DCDN.</para>
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// <para>The reason why secure DCDN was locked. For example, a value of financial indicates that an overdue payment exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>financial</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF2AEBC2-EDBD-41CF-BF64-7E095D42D6EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the changes of the WebSocket configuration take effect. The value is the same as that of the ChangingAffectTime parameter. This parameter can be displayed in the console only if the specified time is later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-19T11:16:11Z</para>
        /// </summary>
        [NameInMap("WebsocketChangingTime")]
        [Validation(Required=false)]
        public string WebsocketChangingTime { get; set; }

        /// <summary>
        /// <para>The next effective billing method of WebSocket. Valid values: <b>websockettraffic</b> and <b>websocketbps</b>. A value of websockettraffic indicates that you are billed based on the traffic volume. A value of websocketbps indicates that you are billed based on the bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>websocketbps</para>
        /// </summary>
        [NameInMap("WebsocketChangingType")]
        [Validation(Required=false)]
        public string WebsocketChangingType { get; set; }

        /// <summary>
        /// <para>The current billing method of WebSocket. Valid values: <b>websockettraffic</b> and <b>websocketbps</b>. A value of websockettraffic indicates that you are billed based on the traffic volume. A value of websocketbps indicates that you are billed based on the bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>websocketbps</para>
        /// </summary>
        [NameInMap("WebsocketType")]
        [Validation(Required=false)]
        public string WebsocketType { get; set; }

    }

}
