// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudProcessMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The application status list.</para>
        /// </summary>
        [NameInMap("ProcessMonitors")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudProcessMonitorResponseBodyProcessMonitors> ProcessMonitors { get; set; }
        public class DescribeHybridCloudProcessMonitorResponseBodyProcessMonitors : TeaModel {
            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: Normal.</description></item>
            /// <item><description><b>critical</b>: abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Levle")]
            [Validation(Required=false)]
            public string Levle { get; set; }

            /// <summary>
            /// <para>The service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tianqingproxy</b>: centralized management service.</description></item>
            /// <item><description><b>redis</b>: storage service.</description></item>
            /// <item><description><b>scc</b>: traffic computing service.</description></item>
            /// <item><description><b>keeper</b>: threat intelligence service.</description></item>
            /// <item><description><b>node_exporter</b>: application log upload service.</description></item>
            /// <item><description><b>xagent</b>: traffic detection service.</description></item>
            /// <item><description><b>noproxy</b>: traffic forwarding service.</description></item>
            /// <item><description><b>xloge</b>: attack log upload service.</description></item>
            /// <item><description><b>ilogtail</b>: log collection service.</description></item>
            /// <item><description><b>xlogd</b>: log analysis feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>keeper</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The running status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: abnormal.</description></item>
            /// <item><description><b>1</b>: Normal.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBF79169-B6A0-5C8E-86B2-CFE3****496E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and no longer returns meaningful data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        [Obsolete]
        public int? TotalCount { get; set; }

    }

}
