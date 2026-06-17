// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeACLProtectTrendRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1670397599</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b> (default): internet firewall</para>
        /// </description></item>
        /// <item><description><para><b>vpc</b>: VPC firewall</para>
        /// </description></item>
        /// <item><description><para><b>nat</b>: NAT firewall</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>The time granularity for aggregating trend data, in seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>60</b>: 1 minute</para>
        /// </description></item>
        /// <item><description><para><b>1800</b>: 30 minutes</para>
        /// </description></item>
        /// <item><description><para><b>3600</b>: 1 hour</para>
        /// </description></item>
        /// <item><description><para><b>86400</b> (default): 1 day</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.95.87.130</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1677050306</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
