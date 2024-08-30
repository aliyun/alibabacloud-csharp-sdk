// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTraceAppConfigRequest : TeaModel {
        /// <summary>
        /// The process ID (PID) of the application.
        /// 
        /// You can use one of the following methods to obtain the PID:
        /// 
        /// *   API: Call the [ListTraceApps](https://help.aliyun.com/document_detail/2588008.html) operation
        /// *   Console: Log on to the Application Real-Time Monitoring Service (ARMS) console. In the left-side navigation pane, choose **Application Monitoring** > **Application List**. On the Application List page, click the name of your application. The URL in the address bar contains the PID of the application. The PID is indicated in the pid=xxx format. The PID is usually percent encoded as xxx%40xxx. You must modify this value to remove the percent encoding. For example, if the PID in the URL is xxx%4074xxx, you must replace %40 with an at sign (@) to obtain xxx@74xxx.
        /// 
        /// > 
        /// 
        /// *   To obtain the PID in the console, your application must be monitored by Application Monitoring rather than Managed Service for OpenTelemetry.
        /// 
        /// *   The GetTraceAppConfig operation can query only the custom settings of applications that are monitored by Application Monitoring.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

    }

}
