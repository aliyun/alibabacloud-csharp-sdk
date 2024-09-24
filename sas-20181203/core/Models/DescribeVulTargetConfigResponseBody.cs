// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FBC6E47-7508-58C9-9E76-528E118CB1CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the configurations.</para>
        /// </summary>
        [NameInMap("TargetConfigs")]
        [Validation(Required=false)]
        public List<DescribeVulTargetConfigResponseBodyTargetConfigs> TargetConfigs { get; set; }
        public class DescribeVulTargetConfigResponseBodyTargetConfigs : TeaModel {
            /// <summary>
            /// <para>Indicates whether the vulnerability scan feature is enabled for the server.</para>
            /// <list type="bullet">
            /// <item><description><b>off</b>: disabled</description></item>
            /// <item><description><b>on</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>Indicates whether the vulnerability scan feature is enabled for all servers. Valid values:</para>
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
            /// <para>The type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
            /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
            /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
            /// <item><description><b>emg</b>: urgent vulnerability</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
