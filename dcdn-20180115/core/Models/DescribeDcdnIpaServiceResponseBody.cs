// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the change of the billing method starts to take effect. The time is in GMT. This time appears on the frontend only when it is later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-03-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// <para>The new billing method to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
        /// <item><description><b>PayByBandwidth95</b>: pay-by-95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_monthavg</b>: pay-by-monthly average bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_month4th</b>: pay-by-fourth peak bandwidth per month</description></item>
        /// <item><description><b>PayByBandwidth_monthday95avg</b>: pay-by-monthly average 95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_nighthalf95</b>: pay-by-95th percentile bandwidth (50% off during nighttime)</description></item>
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
        /// <para>1883927335936173</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
        /// <item><description><b>PayByBandwidth95</b>: pay-by-95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_monthavg</b>: pay-by-monthly average bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_month4th</b>: pay-by-fourth peak bandwidth per month</description></item>
        /// <item><description><b>PayByBandwidth_monthday95avg</b>: pay-by-monthly average 95th percentile bandwidth</description></item>
        /// <item><description><b>PayByBandwidth_nighthalf95</b>: pay-by-95th percentile bandwidth (50% off during nighttime)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
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
        /// <para>The lock status of secure DCDN.</para>
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnIpaServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnIpaServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnIpaServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnIpaServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// <para>The reason why the instance is locked. For example, a value of <b>financial</b> indicates that an overdue payment exists.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF2AEBC2-EDBD-41CF-BF64-7E095D42D6EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
