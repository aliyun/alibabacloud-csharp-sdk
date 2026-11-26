// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessApplicationL7SwitchesResponseBody : TeaModel {
        /// <summary>
        /// <para>The Layer 7 application configurations.</para>
        /// </summary>
        [NameInMap("L7Switches")]
        [Validation(Required=false)]
        public List<ListPrivateAccessApplicationL7SwitchesResponseBodyL7Switches> L7Switches { get; set; }
        public class ListPrivateAccessApplicationL7SwitchesResponseBodyL7Switches : TeaModel {
            /// <summary>
            /// <para>The ID of the internal access application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-application-bbbc550d7c6e4db6</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The device tag marking switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("DevTagMarkStatus")]
            [Validation(Required=false)]
            public string DevTagMarkStatus { get; set; }

            /// <summary>
            /// <para>The sensitive application download audit switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("DownloadAuditStatus")]
            [Validation(Required=false)]
            public string DownloadAuditStatus { get; set; }

            /// <summary>
            /// <para>The end port.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<ListPrivateAccessApplicationL7SwitchesResponseBodyL7SwitchesPortRanges> PortRanges { get; set; }
            public class ListPrivateAccessApplicationL7SwitchesResponseBodyL7SwitchesPortRanges : TeaModel {
                /// <summary>
                /// <para>The start port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2379</para>
                /// </summary>
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public int? Begin { get; set; }

                /// <summary>
                /// <para>The end port. Must be greater than or equal to the start port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public int? End { get; set; }

            }

            /// <summary>
            /// <para>The source IP marking switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.**</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("SrcIpMarkStatus")]
            [Validation(Required=false)]
            public string SrcIpMarkStatus { get; set; }

            /// <summary>
            /// <para>The status of the internal access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The request timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TimeoutSec")]
            [Validation(Required=false)]
            public int? TimeoutSec { get; set; }

            /// <summary>
            /// <para>The URL access whitelist rules for the application. These rules take effect only when Status is set to Enabled. An empty value indicates that URLs and request methods are not restricted. A request passes the URL check only when the request path and method meet any group of rules at the same time. Otherwise, the request is blocked. Passing the URL check does not allow requests that are already blocked by an access policy.</para>
            /// </summary>
            [NameInMap("UrlAccessPaths")]
            [Validation(Required=false)]
            public List<ListPrivateAccessApplicationL7SwitchesResponseBodyL7SwitchesUrlAccessPaths> UrlAccessPaths { get; set; }
            public class ListPrivateAccessApplicationL7SwitchesResponseBodyL7SwitchesUrlAccessPaths : TeaModel {
                /// <summary>
                /// <para>The list of HTTP request methods allowed for the paths in this group. An empty value indicates that request methods are not restricted.</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public List<string> AllowMethods { get; set; }

                /// <summary>
                /// <para>The list of URL paths allowed for access in this group. The list must contain at least 1 path and up to 20 paths. This parameter matches the path part in the request, excluding the protocol, domain name, and query parameters.</para>
                /// </summary>
                [NameInMap("Urls")]
                [Validation(Required=false)]
                public List<string> Urls { get; set; }

            }

            /// <summary>
            /// <para>The user marking switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("UserMarkStatus")]
            [Validation(Required=false)]
            public string UserMarkStatus { get; set; }

            /// <summary>
            /// <para>The host anti-bypass switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("ZeroTrustStatus")]
            [Validation(Required=false)]
            public string ZeroTrustStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED459CAD-8D3F-51B8-AEA5-CAABC0325022</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
