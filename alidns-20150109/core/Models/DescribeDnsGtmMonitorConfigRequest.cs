// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the health check configuration.&lt;props=&quot;china&quot;&gt; For more information, see <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describednsgtminstanceaddresspool?spm=a2c4g.11186623.help-menu-29697.d_0_5_1_3_9_6.7db77000nMCPI1">DescribeDnsGtmInstanceAddressPool</a>.&lt;props=&quot;intl&quot;&gt; For more information, see <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describednsgtminstanceaddresspool?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDnsGtmInstanceAddressPool</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Moni*******</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

    }

}
