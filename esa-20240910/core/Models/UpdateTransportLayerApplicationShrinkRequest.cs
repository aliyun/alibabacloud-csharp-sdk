// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateTransportLayerApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Layer 4 application ID. You can call the <a href="~~ListTransportLayerApplications~~">ListTransportLayerApplications</a> operation to obtain the application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165503967****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable network access optimization for the Chinese mainland. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public string CrossBorderOptimization { get; set; }

        /// <summary>
        /// <para>The IP access rule switch. When enabled, WAF IP access rules take effect for the Layer 4 application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("IpAccessRule")]
        [Validation(Required=false)]
        public string IpAccessRule { get; set; }

        /// <summary>
        /// <para>The IPv6 switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable keep-alive protection. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("KeepAliveProtection")]
        [Validation(Required=false)]
        public string KeepAliveProtection { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules. For each rule, all parameters except the comment are required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable static IP. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StaticIp")]
        [Validation(Required=false)]
        public string StaticIp { get; set; }

    }

}
