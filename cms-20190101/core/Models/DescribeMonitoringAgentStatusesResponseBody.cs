// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NodeStatusList")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentStatusesResponseBodyNodeStatusList NodeStatusList { get; set; }
        public class DescribeMonitoringAgentStatusesResponseBodyNodeStatusList : TeaModel {
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentStatusesResponseBodyNodeStatusListNodeStatus> NodeStatus { get; set; }
            public class DescribeMonitoringAgentStatusesResponseBodyNodeStatusListNodeStatus : TeaModel {
                [NameInMap("AgentInstallErrorCode")]
                [Validation(Required=false)]
                public string AgentInstallErrorCode { get; set; }

                [NameInMap("AutoInstall")]
                [Validation(Required=false)]
                public bool? AutoInstall { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LoongCollectorStatus")]
                [Validation(Required=false)]
                public string LoongCollectorStatus { get; set; }

                [NameInMap("LoongCollectorVersion")]
                [Validation(Required=false)]
                public string LoongCollectorVersion { get; set; }

                [NameInMap("OsMonitorConfig")]
                [Validation(Required=false)]
                public string OsMonitorConfig { get; set; }

                [NameInMap("OsMonitorErrorCode")]
                [Validation(Required=false)]
                public string OsMonitorErrorCode { get; set; }

                [NameInMap("OsMonitorErrorDetail")]
                [Validation(Required=false)]
                public string OsMonitorErrorDetail { get; set; }

                [NameInMap("OsMonitorStatus")]
                [Validation(Required=false)]
                public string OsMonitorStatus { get; set; }

                [NameInMap("OsMonitorVersion")]
                [Validation(Required=false)]
                public string OsMonitorVersion { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F8371DF-AB81-41B8-9E1B-5493B3FF0E4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
