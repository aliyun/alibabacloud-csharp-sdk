// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudProcessMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application statuses.</para>
        /// </summary>
        [NameInMap("ProcessMonitors")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudProcessMonitorResponseBodyProcessMonitors> ProcessMonitors { get; set; }
        public class DescribeHybridCloudProcessMonitorResponseBodyProcessMonitors : TeaModel {
            /// <summary>
            /// <para>The severity level of the application status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>normal</b>: normal.</para>
            /// </description></item>
            /// <item><description><para><b>critical</b>: abnormal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Levle")]
            [Validation(Required=false)]
            public string Levle { get; set; }

            /// <summary>
            /// <para>The name of the application running on the cluster node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>tianqingproxy</b>: the central management service</para>
            /// </description></item>
            /// <item><description><para><b>redis</b>: the storage service</para>
            /// </description></item>
            /// <item><description><para><b>scc</b>: the traffic metering service</para>
            /// </description></item>
            /// <item><description><para><b>keeper</b>: the threat intelligence service</para>
            /// </description></item>
            /// <item><description><para><b>node_exporter</b>: the application log upload service</para>
            /// </description></item>
            /// <item><description><para><b>xagent</b>: the traffic detection service</para>
            /// </description></item>
            /// <item><description><para><b>noproxy</b>: the traffic forwarding service</para>
            /// </description></item>
            /// <item><description><para><b>xloge</b>: the attack log upload service</para>
            /// </description></item>
            /// <item><description><para><b>ilogtail</b>: the log collection service</para>
            /// </description></item>
            /// <item><description><para><b>xlogd</b>: the log analysis service</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>keeper</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The running status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: abnormal.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: normal.</para>
            /// </description></item>
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

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated and no longer returns a valid value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
