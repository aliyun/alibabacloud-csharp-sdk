// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyAvailableConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describednsgtminstances">DescribeDnsGtmInstances</a> operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response. Default: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The scheduling mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GEO: Geolocation-based</para>
        /// </description></item>
        /// <item><description><para>LATENCY: Latency-based</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GEO</para>
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

    }

}
