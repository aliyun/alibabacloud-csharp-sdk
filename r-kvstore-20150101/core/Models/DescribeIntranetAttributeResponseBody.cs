// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeIntranetAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the purchased bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not returned if no bandwidth has been purchased.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The expiration time of the purchased bandwidth, in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format.</para>
        /// <remarks>
        /// <para>This parameter is not returned if no additional bandwidth has been purchased for the instance.</para>
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
        /// <item><description><b>0</b>: pay-as-you-go.</description></item>
        /// <item><description><b>1</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BandwidthPrePaid")]
        [Validation(Required=false)]
        public string BandwidthPrePaid { get; set; }

        /// <summary>
        /// <para>The expiration time of the temporary bandwidth, in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format.</para>
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
        /// <para>Indicates whether the instance has an unexpired bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: An unexpired bandwidth plan exists.</description></item>
        /// <item><description><b>false</b>: No unexpired bandwidth plan exists.<remarks>
        /// <para>This parameter is not returned if no additional bandwidth has been purchased for the instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>The current internal network bandwidth of the instance. This parameter indicates the total bandwidth of all shards in the instance. Unit: MB/s.</para>
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
