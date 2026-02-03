// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeIntranetAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the extra internal bandwidth that you purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b>: Auto-renewal is disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If no extra internal bandwidth is purchased, this parameter is not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The expiration time of the purchased bandwidth. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em> T <em>HH:mm:ss</em> Z format.</para>
        /// <remarks>
        /// <para>If no extra internal bandwidth is purchased, this parameter is not returned.</para>
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
        /// <item><description><b>0</b>: pay-as-you-go</description></item>
        /// <item><description><b>1</b>: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BandwidthPrePaid")]
        [Validation(Required=false)]
        public string BandwidthPrePaid { get; set; }

        /// <summary>
        /// <para>The time when the extra internal bandwidth that you purchased for temporary use expires. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <para>If no extra internal bandwidth for temporary use is purchased or the extra internal bandwidth that you purchased for temporary use has expired, <b>0</b> is returned for this parameter.</para>
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
        /// <para>If no extra internal bandwidth is purchased, this parameter is not returned.</para>
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
        /// <para>The internal bandwidth of the instance. This parameter indicates the combined bandwidth of all shards in the instance. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102</para>
        /// </summary>
        [NameInMap("IntranetBandwidth")]
        [Validation(Required=false)]
        public int? IntranetBandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25D42CC3-FBA1-4AEC-BCE2-B8DD3137****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
