// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAllInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAllInstancesResponseBodyData> Data { get; set; }
        public class ListAllInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent configuration ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_id</para>
            /// </summary>
            [NameInMap("agentConfigId")]
            [Validation(Required=false)]
            public string AgentConfigId { get; set; }

            /// <summary>
            /// <para>Agent configuration name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_name</para>
            /// </summary>
            [NameInMap("agentConfigName")]
            [Validation(Required=false)]
            public string AgentConfigName { get; set; }

            /// <summary>
            /// <para>Extension information.</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public List<ListAllInstancesResponseBodyDataAttributes> Attributes { get; set; }
            public class ListAllInstancesResponseBodyDataAttributes : TeaModel {
                /// <summary>
                /// <para>information key</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysom</para>
                /// </summary>
                [NameInMap("infoKey")]
                [Validation(Required=false)]
                public string InfoKey { get; set; }

                /// <summary>
                /// <para>information type</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_tag</para>
                /// </summary>
                [NameInMap("infoType")]
                [Validation(Required=false)]
                public string InfoType { get; set; }

                /// <summary>
                /// <para>information value</para>
                /// 
                /// <b>Example:</b>
                /// <para>diagnosis</para>
                /// </summary>
                [NameInMap("infoValue")]
                [Validation(Required=false)]
                public string InfoValue { get; set; }

            }

            /// <summary>
            /// <para>Cluster ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b24a621-acb3-11ef-8c90-00163e1029af</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Cluster name</para>
            /// 
            /// <b>Example:</b>
            /// <para>zjk_vpc_domain_1</para>
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>Image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20250117.vhd</para>
            /// </summary>
            [NameInMap("imageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Installation level</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cluster</para>
            /// </summary>
            [NameInMap("installLevel")]
            [Validation(Required=false)]
            public string InstallLevel { get; set; }

            /// <summary>
            /// <para>Installation type</para>
            /// 
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("installType")]
            [Validation(Required=false)]
            public string InstallType { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp17uabeke9v7n30abm2</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Instance type</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Milvus version</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.10.134-18.al8.x86_64</para>
            /// </summary>
            [NameInMap("kernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>Management level</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("manageLevel")]
            [Validation(Required=false)]
            public string ManageLevel { get; set; }

            /// <summary>
            /// <para>Management type</para>
            /// 
            /// <b>Example:</b>
            /// <para>managed</para>
            /// </summary>
            [NameInMap("manageType")]
            [Validation(Required=false)]
            public string ManageType { get; set; }

            /// <summary>
            /// <para>Operating system architecture</para>
            /// 
            /// <b>Example:</b>
            /// <para>x86_64</para>
            /// </summary>
            [NameInMap("osArch")]
            [Validation(Required=false)]
            public string OsArch { get; set; }

            /// <summary>
            /// <para>Operating system health score</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("osHealthScore")]
            [Validation(Required=false)]
            public int? OsHealthScore { get; set; }

            /// <summary>
            /// <para>Operating system name</para>
            /// 
            /// <b>Example:</b>
            /// <para>alios</para>
            /// </summary>
            [NameInMap("osName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <para>Private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.172.7</para>
            /// </summary>
            [NameInMap("privateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>Public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.98.215.58</para>
            /// </summary>
            [NameInMap("publicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b24a621-acb3-11ef-8c90-00163e1029af</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Resource group name</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("resourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The running status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: The instance is running.</description></item>
            /// <item><description><b>Offline</b>: The instance is offline.</description></item>
            /// </list>
            /// <remarks>
            /// <para>An instance in the Offline state indicates that the heartbeat from the edge zone to the SysOM Server has been lost. It does not mean that the corresponding ECS instance is not running.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Maximum number of returned items</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Error message:</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the error message of the request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance not exists</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Paging cursor.</para>
        /// <remarks>
        /// <para>If not empty, more data is available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c2f78a783f49457caba6bace6f6f79e4</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
