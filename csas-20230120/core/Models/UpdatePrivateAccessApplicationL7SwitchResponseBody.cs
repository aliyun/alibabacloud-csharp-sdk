// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessApplicationL7SwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The Layer 7 access switch configurations of the internal access application after the update.</para>
        /// </summary>
        [NameInMap("L7Switch")]
        [Validation(Required=false)]
        public UpdatePrivateAccessApplicationL7SwitchResponseBodyL7Switch L7Switch { get; set; }
        public class UpdatePrivateAccessApplicationL7SwitchResponseBodyL7Switch : TeaModel {
            /// <summary>
            /// <para>The ID of the internal access application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-application-e12860ef6c48****</para>
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
            /// <para>The download audit switch for sensitive applications. Valid values:</para>
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
            /// <para>The effective port ranges for Layer 7 access, which are the intersection of the ports specified in this request and the configured port ranges of the internal access application. If Status is set to <b>Disabled</b>, an empty set is returned.</para>
            /// </summary>
            [NameInMap("PortRanges")]
            [Validation(Required=false)]
            public List<UpdatePrivateAccessApplicationL7SwitchResponseBodyL7SwitchPortRanges> PortRanges { get; set; }
            public class UpdatePrivateAccessApplicationL7SwitchResponseBodyL7SwitchPortRanges : TeaModel {
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
            /// <para>The source IP marking switch. Valid values:</para>
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
            /// <para>The master switch for the Layer 7 access switch of the internal access application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The request timeout period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TimeoutSec")]
            [Validation(Required=false)]
            public int? TimeoutSec { get; set; }

            [NameInMap("UrlAccessPaths")]
            [Validation(Required=false)]
            public List<UpdatePrivateAccessApplicationL7SwitchResponseBodyL7SwitchUrlAccessPaths> UrlAccessPaths { get; set; }
            public class UpdatePrivateAccessApplicationL7SwitchResponseBodyL7SwitchUrlAccessPaths : TeaModel {
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public List<string> AllowMethods { get; set; }

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
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("UserMarkStatus")]
            [Validation(Required=false)]
            public string UserMarkStatus { get; set; }

            /// <summary>
            /// <para>The Host bypass prevention switch. Valid values:</para>
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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
