// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAllInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAllInstancesResponseBodyData> Data { get; set; }
        public class ListAllInstancesResponseBodyData : TeaModel {
            [NameInMap("agentConfigId")]
            [Validation(Required=false)]
            public string AgentConfigId { get; set; }

            [NameInMap("agentConfigName")]
            [Validation(Required=false)]
            public string AgentConfigName { get; set; }

            [NameInMap("attributes")]
            [Validation(Required=false)]
            public List<ListAllInstancesResponseBodyDataAttributes> Attributes { get; set; }
            public class ListAllInstancesResponseBodyDataAttributes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sysom</para>
                /// </summary>
                [NameInMap("infoKey")]
                [Validation(Required=false)]
                public string InfoKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>instance_tag</para>
                /// </summary>
                [NameInMap("infoType")]
                [Validation(Required=false)]
                public string InfoType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>diagnosis</para>
                /// </summary>
                [NameInMap("infoValue")]
                [Validation(Required=false)]
                public string InfoValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3b24a621-acb3-11ef-8c90-00163e1029af</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zjk_vpc_domain_1</para>
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun_3_x64_20G_alibase_20250117.vhd</para>
            /// </summary>
            [NameInMap("imageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Cluster</para>
            /// </summary>
            [NameInMap("installLevel")]
            [Validation(Required=false)]
            public string InstallLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("installType")]
            [Validation(Required=false)]
            public string InstallType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-bp17uabeke9v7n30abm2</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5.10.134-18.al8.x86_64</para>
            /// </summary>
            [NameInMap("kernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("manageLevel")]
            [Validation(Required=false)]
            public string ManageLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>managed</para>
            /// </summary>
            [NameInMap("manageType")]
            [Validation(Required=false)]
            public string ManageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>x86_64</para>
            /// </summary>
            [NameInMap("osArch")]
            [Validation(Required=false)]
            public string OsArch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("osHealthScore")]
            [Validation(Required=false)]
            public int? OsHealthScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alios</para>
            /// </summary>
            [NameInMap("osName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.21.172.7</para>
            /// </summary>
            [NameInMap("privateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.98.215.58</para>
            /// </summary>
            [NameInMap("publicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3b24a621-acb3-11ef-8c90-00163e1029af</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("resourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instance not exists</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
