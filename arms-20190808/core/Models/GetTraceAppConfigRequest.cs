// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTraceAppConfigRequest : TeaModel {
        /// <summary>
        /// <para>The process ID (PID) of the application.</para>
        /// <para>You can use one of the following methods to obtain the PID:</para>
        /// <list type="bullet">
        /// <item><description>API: Call the <a href="https://help.aliyun.com/document_detail/2588008.html">ListTraceApps</a> operation</description></item>
        /// <item><description>Console: Log on to the Application Real-Time Monitoring Service (ARMS) console. In the left-side navigation pane, choose <b>Application Monitoring</b> &gt; <b>Application List</b>. On the Application List page, click the name of your application. The URL in the address bar contains the PID of the application. The PID is indicated in the pid=xxx format. The PID is usually percent encoded as xxx%40xxx. You must modify this value to remove the percent encoding. For example, if the PID in the URL is xxx%4074xxx, you must replace %40 with an at sign (@) to obtain xxx@74xxx.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To obtain the PID in the console, your application must be monitored by Application Monitoring rather than Managed Service for OpenTelemetry.</para>
        /// </description></item>
        /// <item><description><para>The GetTraceAppConfig operation can query only the custom settings of applications that are monitored by Application Monitoring.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2n80plglh@745eddxxx</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

    }

}
