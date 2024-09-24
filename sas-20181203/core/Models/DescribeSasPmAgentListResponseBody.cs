// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSasPmAgentListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8EF3ACC2-9400-5B64-B72D-4A1D35113750</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about servers.</para>
        /// </summary>
        [NameInMap("SasPmAgentList")]
        [Validation(Required=false)]
        public List<DescribeSasPmAgentListResponseBodySasPmAgentList> SasPmAgentList { get; set; }
        public class DescribeSasPmAgentListResponseBodySasPmAgentList : TeaModel {
            /// <summary>
            /// <para>The ID of Cloud Assistant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mi-hz034jn***yxhc0</para>
            /// </summary>
            [NameInMap("AliyunAssistId")]
            [Validation(Required=false)]
            public string AliyunAssistId { get; set; }

            /// <summary>
            /// <para>The ID of the CloudMonitor agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5d5ef6be-54ff-11ed-82cf-8f01475e****</para>
            /// </summary>
            [NameInMap("AliyunMonitorId")]
            [Validation(Required=false)]
            public string AliyunMonitorId { get; set; }

            /// <summary>
            /// <para>The installation result of Cloud Assistant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: SUCCESS</description></item>
            /// <item><description><b>1</b>: MISSING_PARAM</description></item>
            /// <item><description><b>2</b>: UNKNOWN_SYSTEM</description></item>
            /// <item><description><b>3</b>: DOWNLOAD_FAILED</description></item>
            /// <item><description><b>4</b>: INSTALL_FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssistInstallResult")]
            [Validation(Required=false)]
            public int? AssistInstallResult { get; set; }

            /// <summary>
            /// <para>The status of Cloud Assistant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: installing</description></item>
            /// <item><description><b>1</b>: installed</description></item>
            /// <item><description><b>2</b>: installation failed</description></item>
            /// <item><description><b>3</b>: installation timed out</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssistInstallStatus")]
            [Validation(Required=false)]
            public int? AssistInstallStatus { get; set; }

            /// <summary>
            /// <para>The installation result of the CloudMonitor agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: failed</description></item>
            /// <item><description><b>1</b>: successful</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MonitorInstallResult")]
            [Validation(Required=false)]
            public int? MonitorInstallResult { get; set; }

            /// <summary>
            /// <para>The status of the CloudMonitor agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: installation failed</description></item>
            /// <item><description><b>1</b>: installed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MonitorInstallStatus")]
            [Validation(Required=false)]
            public int? MonitorInstallStatus { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87f1724d-075e-48d3-95fd-78c2dd36****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
