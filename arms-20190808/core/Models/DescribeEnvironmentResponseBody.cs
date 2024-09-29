// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvironmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvironmentResponseBodyData Data { get; set; }
        public class DescribeEnvironmentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the resource associated with the environment, such as the ACK cluster ID or VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxxxx</para>
            /// </summary>
            [NameInMap("BindResourceId")]
            [Validation(Required=false)]
            public string BindResourceId { get; set; }

            /// <summary>
            /// <para>The profile of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("BindResourceProfile")]
            [Validation(Required=false)]
            public string BindResourceProfile { get; set; }

            /// <summary>
            /// <para>The status of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("BindResourceStatus")]
            [Validation(Required=false)]
            public string BindResourceStatus { get; set; }

            /// <summary>
            /// <para>The retention period of the resource. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("BindResourceStoreDuration")]
            [Validation(Required=false)]
            public string BindResourceStoreDuration { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("BindResourceType")]
            [Validation(Required=false)]
            public string BindResourceType { get; set; }

            /// <summary>
            /// <para>The VPC CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("BindVpcCidr")]
            [Validation(Required=false)]
            public string BindVpcCidr { get; set; }

            /// <summary>
            /// <para>The status of the database that is bound to the Prometheus instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>UNINSTALLING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>INSTALLING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>UNINSTALLED</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>RUNNING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>MODIFYING</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("DbInstanceStatus")]
            [Validation(Required=false)]
            public string DbInstanceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the environment instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-xxxxx</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The environment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env1</para>
            /// </summary>
            [NameInMap("EnvironmentName")]
            [Validation(Required=false)]
            public string EnvironmentName { get; set; }

            /// <summary>
            /// <para>Environment subtypes:</para>
            /// <list type="bullet">
            /// <item><description>CS: Currently supports ACK.</description></item>
            /// <item><description>ECS: ECS is currently supported.</description></item>
            /// <item><description>Cloud: Currently supports Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACK</para>
            /// </summary>
            [NameInMap("EnvironmentSubType")]
            [Validation(Required=false)]
            public string EnvironmentSubType { get; set; }

            /// <summary>
            /// <para>The type of the environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CS: Container Service for Kubernetes (ACK)</description></item>
            /// <item><description>ECS: Elastic Compute Service</description></item>
            /// <item><description>Cloud: cloud service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CS</para>
            /// </summary>
            [NameInMap("EnvironmentType")]
            [Validation(Required=false)]
            public string EnvironmentType { get; set; }

            /// <summary>
            /// <para>The payable resource plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the EnvironmentType parameter is set to CS, set the value to CS_Basic or CS_Pro.</description></item>
            /// <item><description>Otherwise, leave the parameter empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CS_Basic</para>
            /// </summary>
            [NameInMap("FeePackage")]
            [Validation(Required=false)]
            public string FeePackage { get; set; }

            /// <summary>
            /// <para>The name of the Grafana data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datasource1</para>
            /// </summary>
            [NameInMap("GrafaDataSourceName")]
            [Validation(Required=false)]
            public string GrafaDataSourceName { get; set; }

            /// <summary>
            /// <para>The unique ID of the Grafana data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zuvw</para>
            /// </summary>
            [NameInMap("GrafanaDatasourceUid")]
            [Validation(Required=false)]
            public string GrafanaDatasourceUid { get; set; }

            /// <summary>
            /// <para>The name of the Grafana directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>folder1</para>
            /// </summary>
            [NameInMap("GrafanaFolderTitle")]
            [Validation(Required=false)]
            public string GrafanaFolderTitle { get; set; }

            /// <summary>
            /// <para>The unique ID of the Grafana directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xyz</para>
            /// </summary>
            [NameInMap("GrafanaFolderUid")]
            [Validation(Required=false)]
            public string GrafanaFolderUid { get; set; }

            /// <summary>
            /// <para>The URL of the Grafana directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://g.console.aliyun.com/dashboards/f/xxx/yyyy">https://g.console.aliyun.com/dashboards/f/xxx/yyyy</a></para>
            /// </summary>
            [NameInMap("GrafanaFolderUrl")]
            [Validation(Required=false)]
            public string GrafanaFolderUrl { get; set; }

            /// <summary>
            /// <para>The ID of the Grafana workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>grafana-cn-27a3m8eem0a</para>
            /// </summary>
            [NameInMap("GrafanaWorkspaceId")]
            [Validation(Required=false)]
            public string GrafanaWorkspaceId { get; set; }

            /// <summary>
            /// <para>managed type:</para>
            /// <list type="bullet">
            /// <item><description>none: unmanaged. The default value for ACK clusters.</description></item>
            /// <item><description>agent: managed agent (including KSM). The default values for ASK, ACS, and AckOne clusters.</description></item>
            /// <item><description>agent-exporter: managed agent and exporters. The default value for the cloud service type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("ManagedType")]
            [Validation(Required=false)]
            public string ManagedType { get; set; }

            /// <summary>
            /// <para>The ID of the Prometheus instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxyyyyyzzzzz</para>
            /// </summary>
            [NameInMap("PrometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Prometheus instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name1</para>
            /// </summary>
            [NameInMap("PrometheusInstanceName")]
            [Validation(Required=false)]
            public string PrometheusInstanceName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2vezare****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the security group associated with the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-8vbdgmf4nraiqa9bx0jo</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeEnvironmentResponseBodyDataTags> Tags { get; set; }
            public class DescribeEnvironmentResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>p_dev</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13002222xxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-8vb02uk57qbcktqcvqqqj</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch associated with the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze7yr3f1x8snryaioo7u</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C21AB7CF-B7AF-410F-BD61-82D1567F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
