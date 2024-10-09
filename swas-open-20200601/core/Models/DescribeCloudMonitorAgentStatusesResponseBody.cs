// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCloudMonitorAgentStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the Cloud Monitor agent was automatically installed on the simple application server.</para>
        /// </summary>
        [NameInMap("InstanceStatusList")]
        [Validation(Required=false)]
        public List<DescribeCloudMonitorAgentStatusesResponseBodyInstanceStatusList> InstanceStatusList { get; set; }
        public class DescribeCloudMonitorAgentStatusesResponseBodyInstanceStatusList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Cloud Monitor agent was automatically installed on the simple application server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoInstall")]
            [Validation(Required=false)]
            public bool? AutoInstall { get; set; }

            /// <summary>
            /// <para>The ID of the simple application server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c854dc6f07e74953830bb5808d0****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The running status of the Cloud Monitoring plug-in. Possible values are:</para>
            /// <list type="bullet">
            /// <item><description>running: Cloud Monitoring plug-in running.</description></item>
            /// <item><description>stopped: Cloud Monitoring plug-in stopped.</description></item>
            /// <item><description>installing: Cloud Monitoring plug-in installing.</description></item>
            /// <item><description>install_faild: Cloud Monitoring plug-in installation failed.</description></item>
            /// <item><description>abnormal: Cloud Monitoring plug-in installation abnormal.</description></item>
            /// <item><description>not_installed: Cloud Monitoring plug-in not installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E1FEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
