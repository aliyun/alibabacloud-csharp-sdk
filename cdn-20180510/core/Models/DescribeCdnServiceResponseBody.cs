// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the metering method for the next cycle takes effect. The time is displayed in GMT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-27T16:00:00Z</para>
        /// </summary>
        [NameInMap("ChangingAffectTime")]
        [Validation(Required=false)]
        public string ChangingAffectTime { get; set; }

        /// <summary>
        /// <para>The metering method for the next cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("ChangingChargeType")]
        [Validation(Required=false)]
        public string ChangingChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliuidxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The current metering method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The time when the service was activated. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T13:11:49Z</para>
        /// </summary>
        [NameInMap("OpeningTime")]
        [Validation(Required=false)]
        public string OpeningTime { get; set; }

        /// <summary>
        /// <para>The lock status.</para>
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeCdnServiceResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeCdnServiceResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeCdnServiceResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeCdnServiceResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// <para>The reason why the service is locked. A value of financial indicates that the service is locked due to overdue payments.</para>
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
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
