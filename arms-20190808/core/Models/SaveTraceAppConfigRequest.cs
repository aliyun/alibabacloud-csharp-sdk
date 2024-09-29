// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SaveTraceAppConfigRequest : TeaModel {
        /// <summary>
        /// <para>The process ID (PID) of the application.</para>
        /// <para>Log on to the ARMS console. In the left-side navigation pane, choose <b>Application Monitoring</b> &gt; <b>Application List</b>. On the Application List page, click the name of an application. The URL in the address bar contains the PID of the application. The PID is indicated in the pid=xxx format. The PID is usually percent encoded as xxx%40xxx. You must modify this value to remove the percent encoding. For example, if the PID in the URL is xxx%4074xxx, you must replace %40 with an at sign (@) to obtain xxx@74xxx.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2n80plglh@745eddxxx</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The settings of Application Monitoring.</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public List<SaveTraceAppConfigRequestSettings> Settings { get; set; }
        public class SaveTraceAppConfigRequestSettings : TeaModel {
            /// <summary>
            /// <para>The key of the settings that you want to modify. For more information about the supported settings, see the following sections.</para>
            /// <list type="bullet">
            /// <item><description>Trace sampling settings</description></item>
            /// <item><description>Agent switch settings</description></item>
            /// <item><description>Threshold settings</description></item>
            /// <item><description>Advanced settings</description></item>
            /// <item><description>Thread settings</description></item>
            /// <item><description>Memory snapshot settings</description></item>
            /// <item><description>URL convergence settings</description></item>
            /// <item><description>Business log association settings</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sampling.enable</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the settings that you want to modify. For more information about the supported settings, see the following sections.</para>
            /// <list type="bullet">
            /// <item><description>Trace sampling settings</description></item>
            /// <item><description>Agent switch settings</description></item>
            /// <item><description>Threshold settings</description></item>
            /// <item><description>Advanced settings</description></item>
            /// <item><description>Thread settings</description></item>
            /// <item><description>Memory snapshot settings</description></item>
            /// <item><description>URL convergence settings</description></item>
            /// <item><description>Business log association settings</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
