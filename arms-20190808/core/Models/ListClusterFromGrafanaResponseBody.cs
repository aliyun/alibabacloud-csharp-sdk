// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListClusterFromGrafanaResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster information.</para>
        /// </summary>
        [NameInMap("PromClusterList")]
        [Validation(Required=false)]
        public List<ListClusterFromGrafanaResponseBodyPromClusterList> PromClusterList { get; set; }
        public class ListClusterFromGrafanaResponseBodyPromClusterList : TeaModel {
            /// <summary>
            /// <para>The status of the Prometheus agent on the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INSTALL_FAILED: The Prometheus agent failed to be installed.</description></item>
            /// <item><description>INSTALL_SUCCEED: The Prometheus agent was installed.</description></item>
            /// <item><description>NOT_REGISTER: You have not registered an Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALL_FAILED</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0df7ad9db0ed43128925ca04774c469e</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ay-ads-hangzhou</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The type of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud-product-prometheus</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The controller ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1092</para>
            /// </summary>
            [NameInMap("ControllerId")]
            [Validation(Required=false)]
            public string ControllerId { get; set; }

            /// <summary>
            /// <para>The time when the dashboard was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-09T02:05:04Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The extended fields. This parameter is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;app_id\&quot;:\&quot;bbd\&quot;,\&quot;task_id\&quot;:\&quot;4305ba5bf14942daa6e553ed91f46988\&quot;}</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The ID of a database in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16136</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The timestamp when the Prometheus agent was installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653532518000</para>
            /// </summary>
            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public long? InstallTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the Prometheus agent was installed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The Prometheus agent was installed.</description></item>
            /// <item><description>false: The Prometheus agent was not installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsControllerInstalled")]
            [Validation(Required=false)]
            public bool? IsControllerInstalled { get; set; }

            /// <summary>
            /// <para>The time when the last heartbeat was reported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653532518000</para>
            /// </summary>
            [NameInMap("LastHeartBeatTime")]
            [Validation(Required=false)]
            public long? LastHeartBeatTime { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// <para>The custom parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Option\&quot;: [\&quot;betaTestApproved\&quot;]}</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <para>The list of nodejsonar logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("PluginsJsonArray")]
            [Validation(Required=false)]
            public string PluginsJsonArray { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The information about applications deployed in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("StateJson")]
            [Validation(Required=false)]
            public string StateJson { get; set; }

            /// <summary>
            /// <para>The time when the dashboard was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-16T08:49:34Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1247285**</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6849D41E-EED4-5C00-89F9-6047BBD9DCB4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
