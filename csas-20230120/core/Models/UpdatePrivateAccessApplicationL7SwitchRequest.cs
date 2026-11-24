// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessApplicationL7SwitchRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the internal access application. Required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The device tag marking switch. Required. Valid values:</para>
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
        /// <para>The download audit switch for sensitive applications. Optional. Valid values:</para>
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
        /// <para>The port ranges for the internal access application. Multiple port ranges cannot overlap or be duplicated. You can specify up to 50 port ranges. This parameter takes effect and is verified only when Status is set to <b>Enabled</b>. If this parameter is not specified or an empty set is specified, the default ports 80, 443, 8080, and 465 are used. The effective ports are the intersection of the ports specified in this request and the configured port ranges of the internal access application.</para>
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessApplicationL7SwitchRequestPortRanges> PortRanges { get; set; }
        public class UpdatePrivateAccessApplicationL7SwitchRequestPortRanges : TeaModel {
            /// <summary>
            /// <para>The start port. The value must be less than or equal to the end port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <para>The end port. The value must be greater than or equal to the start port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

        /// <summary>
        /// <para>The source IP marking switch. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("SrcIpMarkStatus")]
        [Validation(Required=false)]
        public string SrcIpMarkStatus { get; set; }

        /// <summary>
        /// <para>The master switch for the Layer 7 access switch of the internal access application. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// <para>When the value is set to <b>Disabled</b>, PortRanges is neither verified nor saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The request timeout period, in seconds. Valid values: 1 to 3600. Default value: 60. If this parameter is not specified or an invalid value is specified, the default value 60 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TimeoutSec")]
        [Validation(Required=false)]
        public int? TimeoutSec { get; set; }

        [NameInMap("UrlAccessPaths")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessApplicationL7SwitchRequestUrlAccessPaths> UrlAccessPaths { get; set; }
        public class UpdatePrivateAccessApplicationL7SwitchRequestUrlAccessPaths : TeaModel {
            [NameInMap("AllowMethods")]
            [Validation(Required=false)]
            public List<string> AllowMethods { get; set; }

            [NameInMap("Urls")]
            [Validation(Required=false)]
            public List<string> Urls { get; set; }

        }

        /// <summary>
        /// <para>The user marking switch. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("UserMarkStatus")]
        [Validation(Required=false)]
        public string UserMarkStatus { get; set; }

        /// <summary>
        /// <para>The Host bypass prevention switch. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ZeroTrustStatus")]
        [Validation(Required=false)]
        public string ZeroTrustStatus { get; set; }

    }

}
