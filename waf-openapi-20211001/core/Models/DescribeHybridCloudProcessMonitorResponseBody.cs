// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudProcessMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the applications.</para>
        /// </summary>
        [NameInMap("ProcessMonitors")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudProcessMonitorResponseBodyProcessMonitors> ProcessMonitors { get; set; }
        public class DescribeHybridCloudProcessMonitorResponseBodyProcessMonitors : TeaModel {
            [NameInMap("Levle")]
            [Validation(Required=false)]
            public string Levle { get; set; }

            /// <summary>
            /// <para>The service that the application provides. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tianqingproxy</b>: centralized management service.</description></item>
            /// <item><description><b>redis</b>: storage service.</description></item>
            /// <item><description><b>scc</b>: traffic calculation service.</description></item>
            /// <item><description><b>keeper</b>: threat intelligence service.</description></item>
            /// <item><description><b>node_exporter</b>: application log upload service.</description></item>
            /// <item><description><b>xagent</b>: traffic detection service.</description></item>
            /// <item><description><b>noproxy</b>: traffic forwarding service.</description></item>
            /// <item><description><b>xloge</b>: attack log upload service.</description></item>
            /// <item><description><b>ilogtail</b>: log collection service.</description></item>
            /// <item><description><b>xlogd</b>: log analysis service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tianqingproxy</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: abnormal.</description></item>
            /// <item><description><b>1</b>: normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public long? ProcessStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBF79169-B6A0-5C8E-86B2-CFE3****496E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
