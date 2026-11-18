// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeIntranetAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether auto-renewal is enabled for the purchased bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not returned if no bandwidth is purchased.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The expiration time of the purchased bandwidth. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format.</para>
        /// <remarks>
        /// <para>This parameter is not returned if no additional bandwidth is purchased for the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-06T16:00:00Z</para>
        /// </summary>
        [NameInMap("BandwidthExpireTime")]
        [Validation(Required=false)]
        public string BandwidthExpireTime { get; set; }

        /// <summary>
        /// <para>The billing method of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Pay-as-you-go.</description></item>
        /// <item><description><b>1</b>: Subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BandwidthPrePaid")]
        [Validation(Required=false)]
        public string BandwidthPrePaid { get; set; }

        /// <summary>
        /// <para>The expiration time of the temporary bandwidth. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format.</para>
        /// <remarks>
        /// <para>If no temporary bandwidth adjustment has been performed on the instance or the temporary bandwidth has expired, this parameter returns <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance has unexpired bandwidth plans. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance has unexpired bandwidth plans.</description></item>
        /// <item><description><b>false</b>: The instance does not have unexpired bandwidth plans.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not returned if no additional bandwidth is purchased for the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasPrePaidBandWidthOrderRunning")]
        [Validation(Required=false)]
        public bool? HasPrePaidBandWidthOrderRunning { get; set; }

        /// <summary>
        /// <para>The burst quota for the internal network bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntranetBandWidthBurst")]
        [Validation(Required=false)]
        public int? IntranetBandWidthBurst { get; set; }

        /// <summary>
        /// <para>The current internal network bandwidth of the instance. This value is the sum of the bandwidth of all shards in the instance. Unit: MB/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102</para>
        /// </summary>
        [NameInMap("IntranetBandwidth")]
        [Validation(Required=false)]
        public int? IntranetBandwidth { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25D42CC3-FBA1-4AEC-BCE2-B8DD3137****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
