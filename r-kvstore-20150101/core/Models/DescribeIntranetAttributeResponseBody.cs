// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeIntranetAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the bandwidth package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Auto-renewal is disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not returned if no additional bandwidth is purchased.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The expiration time of the bandwidth package. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format.</para>
        /// <remarks>
        /// <para>This parameter is not returned if no additional bandwidth is purchased.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-06T16:00:00Z</para>
        /// </summary>
        [NameInMap("BandwidthExpireTime")]
        [Validation(Required=false)]
        public string BandwidthExpireTime { get; set; }

        /// <summary>
        /// <para>The billing method of the bandwidth package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BandwidthPrePaid")]
        [Validation(Required=false)]
        public string BandwidthPrePaid { get; set; }

        /// <summary>
        /// <para>The expiration time of the temporary bandwidth. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format.</para>
        /// <remarks>
        /// <para>This parameter returns <b>0</b> if the instance has no temporary bandwidth or if the temporary bandwidth has expired.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance has an unexpired bandwidth package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: An unexpired bandwidth package exists.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No unexpired bandwidth package exists.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not returned if no additional bandwidth is purchased.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasPrePaidBandWidthOrderRunning")]
        [Validation(Required=false)]
        public bool? HasPrePaidBandWidthOrderRunning { get; set; }

        [NameInMap("IntranetBandWidthBurst")]
        [Validation(Required=false)]
        public int? IntranetBandWidthBurst { get; set; }

        /// <summary>
        /// <para>The total intranet bandwidth across all shards in the instance, in MB/s.</para>
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
