// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
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
        public ListEnvironmentsResponseBodyData Data { get; set; }
        public class ListEnvironmentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried environments.</para>
            /// </summary>
            [NameInMap("Environments")]
            [Validation(Required=false)]
            public List<ListEnvironmentsResponseBodyDataEnvironments> Environments { get; set; }
            public class ListEnvironmentsResponseBodyDataEnvironments : TeaModel {
                /// <summary>
                /// <para>The add-ons.</para>
                /// </summary>
                [NameInMap("Addons")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsAddons> Addons { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsAddons : TeaModel {
                    /// <summary>
                    /// <para>The alias of the add-on.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL Exporter</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The description of the add-on.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Collect mysql indicator information</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The URL of the icon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxx">http://xxxx</a></para>
                    /// </summary>
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// <para>The name of the add-on.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>metric-agent</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The ID of the resource bound to the environment instance. The resource can be a Kubernetes cluster or a VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1bgo8ronn</para>
                /// </summary>
                [NameInMap("BindResourceId")]
                [Validation(Required=false)]
                public string BindResourceId { get; set; }

                /// <summary>
                /// <para>The profile that is bound to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("BindResourceProfile")]
                [Validation(Required=false)]
                public string BindResourceProfile { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("BindResourceType")]
                [Validation(Required=false)]
                public string BindResourceType { get; set; }

                /// <summary>
                /// <para>The CIDR block that is bound to the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.0.0/12</para>
                /// </summary>
                [NameInMap("BindVpcCidr")]
                [Validation(Required=false)]
                public string BindVpcCidr { get; set; }

                /// <summary>
                /// <para>The time when the environment instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-24 11:58:35 +0800</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12378523784982</para>
                /// </summary>
                [NameInMap("CreatedUserId")]
                [Validation(Required=false)]
                public string CreatedUserId { get; set; }

                /// <summary>
                /// <para>The ID of the environment instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-xxx</para>
                /// </summary>
                [NameInMap("EnvironmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The name of the environment instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>feiliks-biz-prod-edas</para>
                /// </summary>
                [NameInMap("EnvironmentName")]
                [Validation(Required=false)]
                public string EnvironmentName { get; set; }

                /// <summary>
                /// <para>The type of the environment instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CS: Container Service</description></item>
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
                /// <para>The parameters of the feature.</para>
                /// </summary>
                [NameInMap("Features")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsFeatures> Features { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsFeatures : TeaModel {
                    /// <summary>
                    /// <para>The alias of the feature.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prometheus Agent</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The description of the feature.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Collect Metric data using the Prometheus collection specification</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The URL of the icon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxx">http://xxx</a></para>
                    /// </summary>
                    [NameInMap("Icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// <para>The name of the feature.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>metirc-agent</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The payable resource plan.</para>
                /// <list type="bullet">
                /// <item><description>If the EnvironmentType parameter is set to CS, set the value to CS_Basic or CS_Pro.</description></item>
                /// <item><description>Otherwise, leave the parameter empty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CS_Pro</para>
                /// </summary>
                [NameInMap("FeePackage")]
                [Validation(Required=false)]
                public string FeePackage { get; set; }

                /// <summary>
                /// <para>The unique ID of the Grafana data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12374890</para>
                /// </summary>
                [NameInMap("GrafanaDatasourceUid")]
                [Validation(Required=false)]
                public string GrafanaDatasourceUid { get; set; }

                /// <summary>
                /// <para>The name of the Grafana directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filepath</para>
                /// </summary>
                [NameInMap("GrafanaFolderTitle")]
                [Validation(Required=false)]
                public string GrafanaFolderTitle { get; set; }

                /// <summary>
                /// <para>The unique ID of the Grafana directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1798319482935</para>
                /// </summary>
                [NameInMap("GrafanaFolderUid")]
                [Validation(Required=false)]
                public string GrafanaFolderUid { get; set; }

                /// <summary>
                /// <para>The time when the last add-on was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-22T16:56:29+08:00</para>
                /// </summary>
                [NameInMap("LatestReleaseCreateTime")]
                [Validation(Required=false)]
                public string LatestReleaseCreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether agents or exporters are managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>none: No. By default, no managed agents or exporters are provided for ACK clusters.</description></item>
                /// <item><description>agent: Agents are managed. By default, managed agents are provided for ASK clusters, ACS clusters, and ACK One clusters.</description></item>
                /// <item><description>agent-exproter: Agents and exporters are managed. By default, managed agents and exporters are provided for cloud services.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("ManagedType")]
                [Validation(Required=false)]
                public string ManagedType { get; set; }

                /// <summary>
                /// <para>The Prometheus ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>124769812</para>
                /// </summary>
                [NameInMap("PrometheusId")]
                [Validation(Required=false)]
                public long? PrometheusId { get; set; }

                /// <summary>
                /// <para>The ID of the Prometheus instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5e4alj2i24ndbn</para>
                /// </summary>
                [NameInMap("PrometheusInstanceId")]
                [Validation(Required=false)]
                public string PrometheusInstanceId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of installed add-ons.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("ReleaseCount")]
                [Validation(Required=false)]
                public int? ReleaseCount { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmvt3xpr5aema</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags of the environment resource.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListEnvironmentsResponseBodyDataEnvironmentsTags> Tags { get; set; }
                public class ListEnvironmentsResponseBodyDataEnvironmentsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fpx-tag</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13990957477389</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A9C645C-C83F-4C9D-8CCB-29BEC9E1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
