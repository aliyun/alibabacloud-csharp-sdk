// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDnsGtmMonitorStatusRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values: en, zh, and ja. The default value is en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the health check configuration. You can call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describednsgtminstanceaddresspool">DescribeDnsGtmInstanceAddressPool</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monito*****</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>The status to set for the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: Enables the health check.</para>
        /// </description></item>
        /// <item><description><para>CLOSE: Disables the health check.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
