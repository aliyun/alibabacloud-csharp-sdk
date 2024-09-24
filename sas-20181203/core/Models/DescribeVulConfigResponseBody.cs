// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the configurations of vulnerability management.</para>
        /// </summary>
        [NameInMap("TargetConfigs")]
        [Validation(Required=false)]
        public List<DescribeVulConfigResponseBodyTargetConfigs> TargetConfigs { get; set; }
        public class DescribeVulConfigResponseBodyTargetConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration of vulnerability scan.</para>
            /// <remarks>
            /// <para>Valid values when you set the Type parameter to <b>cve</b>, <b>sys</b>, <b>cms</b>, <b>app</b>, <b>emg</b>, or <b>yum</b>:</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// <para>Valid values when you set the Type parameter to <b>scanMode</b>:</para>
            /// <list type="bullet">
            /// <item><description><para><b>real</b>: displays easily exploitable vulnerability.</para>
            /// </description></item>
            /// <item><description><para><b>all</b>: displays all vulnerabilities.</para>
            /// </description></item>
            /// </list>
            /// <para>When you set the Type parameter to <b>imageVulClean</b>, the value of this parameter indicates the vulnerability retention period in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>Indicates whether the vulnerability management feature is enabled for all servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>off</b>: disabled</description></item>
            /// <item><description><b>on</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("OverAllConfig")]
            [Validation(Required=false)]
            public string OverAllConfig { get; set; }

            /// <summary>
            /// <para>The type of configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
            /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
            /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
            /// <item><description><b>app</b>: application vulnerability that is detected by using web scanner.</description></item>
            /// <item><description><b>emg</b>: urgent vulnerability.</description></item>
            /// <item><description><b>scanMode</b>: displays easily exploitable vulnerability.</description></item>
            /// <item><description><b>imageVulClean</b>: vulnerability retention duration.</description></item>
            /// <item><description><b>yum</b>: preferentially uses YUM or APT sources of Alibaba Cloud to fix vulnerabilities.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
