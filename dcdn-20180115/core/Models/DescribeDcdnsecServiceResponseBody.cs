// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnsecServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the renewed service takes effect. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// <para>The new metering method for the renewed DCDN. Valid values:</para>
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
        /// <para>The number of accelerated domain names that use DCDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130</para>
        /// </summary>
        [NameInMap("DomainNum")]
        [Validation(Required=false)]
        public string DomainNum { get; set; }

        /// <summary>
        /// <para>The service expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-26T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metering method for traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayBySecTraffic</para>
        /// </summary>
        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_dcdnsec_public_cn-123***</para>
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
        /// <para>The lock status of DCDN.</para>
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeDcdnsecServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeDcdnsecServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeDcdnsecServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeDcdnsecServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// <para>The reason why the instance was locked.</para>
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
        /// <para>E20B46E1-9BCD-10E5-AAEF-6D7B737467A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metering method for requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayBySecRequest</para>
        /// </summary>
        [NameInMap("RequestType")]
        [Validation(Required=false)]
        public string RequestType { get; set; }

        /// <summary>
        /// <para>The service activation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-26T02:52:08Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
