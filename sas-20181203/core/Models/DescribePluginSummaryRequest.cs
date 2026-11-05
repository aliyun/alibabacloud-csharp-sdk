// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePluginSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>alinet: AliNet.</para>
        /// </description></item>
        /// <item><description><para>alisecguard: Self-protection.</para>
        /// </description></item>
        /// <item><description><para>alihips: AliHips.</para>
        /// </description></item>
        /// <item><description><para>alidetect: AliDetect.</para>
        /// </description></item>
        /// <item><description><para>yundunmonitor: YundunMonitor.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required. If this parameter is not specified, the API returns HTTP 400 and the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alihips</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

    }

}
