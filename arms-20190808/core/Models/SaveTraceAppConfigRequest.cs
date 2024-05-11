// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SaveTraceAppConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// Log on to the **ARMS console**. In the left-side navigation pane, choose **Application Monitoring** > **Applications**. On the **Applications** page, click the name of an application. The URL in the address bar contains the process ID (PID) of the application. The PID is indicated in the pid=xxx format. The PID is usually percent encoded as xxx%40xxx. You must modify this value to remove the percent encoding. For example, if the PID in the URL is eb4zdose6v%409781be0f44d\\*\\*\\*\\*, you must replace %40 with an at sign (@) to obtain eb4zdose6v@9781be0f44d\\*\\*\\*\\*.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The settings of Application Monitoring.
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public List<SaveTraceAppConfigRequestSettings> Settings { get; set; }
        public class SaveTraceAppConfigRequestSettings : TeaModel {
            /// <summary>
            /// The values of the settings that you want to modify. For information about the supported settings, see the following items:
            /// 
            /// *   Trace sampling settings
            /// *   Main switch settings
            /// *   Threshold settings
            /// *   Advanced settings
            /// *   Thread settings
            /// *   Memory snapshot settings
            /// *   URL convergence settings
            /// *   Business log association settings
            /// *   Business monitoring settings
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The values of the settings that you want to modify. For information about the supported settings, see the following items:
            /// 
            /// *   Trace sampling settings
            /// *   Main switch settings
            /// *   Threshold settings
            /// *   Advanced settings
            /// *   Thread settings
            /// *   Memory snapshot settings
            /// *   URL convergence settings
            /// *   Business log association settings
            /// *   Business monitoring settings
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
