// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether all sub-instances must pass validation before the GlobalView instance is created. Default value: false, which indicates that partial success is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllSubClustersSuccess")]
        [Validation(Required=false)]
        public bool? AllSubClustersSuccess { get; set; }

        /// <summary>
        /// <para>The number of days to automatically archive data after the storage period expires. Valid values: 60, 90, 180, and 365. A value of 0 indicates that data is not archived.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ArchiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        /// <summary>
        /// <para>The Container Service cluster ID. This parameter is required when ClusterType is set to aliyun-cs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster to create. This parameter is required when ClusterType is set to remote-write, ecs, or global-view.</para>
        /// <para>For ecs instances, the ClusterName must follow the format &quot;name-vpc-id&quot;, and the name part cannot exceed 24 characters. Example: &quot;mytest1-vpc-xxxxxxxxxxx&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clusterNameOfTest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>remote-write: Prometheus for Remote Write.</description></item>
        /// <item><description>ecs (no longer supported): Prometheus for ECS.</description></item>
        /// <item><description>global-view: Prometheus for GlobalView.</description></item>
        /// <item><description>aliyun-cs (no longer supported): Prometheus for Container Service.</description></item>
        /// <item><description>cloud-product (no longer supported): Prometheus for Cloud Service.</description></item>
        /// <item><description>cloud-monitor (no longer supported): Prometheus for Hybrid Cloud Monitoring.</description></item>
        /// <item><description>flink (no longer supported): Prometheus for Flink.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remote-write</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The data storage duration, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The ID of the bound Grafana workspace. Set this parameter to &quot;free&quot; when you use the shared Grafana edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grafana-bp1*****</para>
        /// </summary>
        [NameInMap("GrafanaInstanceId")]
        [Validation(Required=false)]
        public string GrafanaInstanceId { get; set; }

        /// <summary>
        /// <para>The Billable methods. Valid values:
        /// POSTPAY: pay-as-you-go based on the number of reported metrics.
        /// POSTPAY_GB: pay-as-you-go based on the volume of written metrics.
        /// Empty: uses the default billing method configured by the user. If no default is configured, the system defaults to billing based on the number of reported metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The actual region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Network Security group ID. This parameter is required when ClusterType is set to ecs or aliyun-cs for a managed ASK cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1********</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The JSON string of sub-instances for the GlobalView instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>当clusterType为global-view时，需要传此参数：需要聚合的集群的信息列表；示例：
        /// [
        ///     {
        ///         &quot;headers&quot;:{</para>
        /// <pre><c>    },
        ///     &quot;regionId&quot;:&quot;cn-hangzhou&quot;,
        ///     &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,
        ///     &quot;extras&quot;:{
        /// 
        ///     },
        ///     &quot;clusterId&quot;:&quot;c39a1048921e04f***********&quot;,
        ///     &quot;sourceName&quot;:&quot;arms-luyao-test&quot;,
        ///     &quot;dataSource&quot;:&quot;&quot;,
        ///     &quot;userId&quot;:&quot;1672753***********&quot;
        /// },
        /// {
        ///     &quot;headers&quot;:{
        /// 
        ///     },
        ///     &quot;regionId&quot;:&quot;cn-beijing&quot;,
        ///     &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,
        ///     &quot;extras&quot;:{
        /// 
        ///     },
        ///     &quot;clusterId&quot;:&quot;c6b6485496d5b40***********&quot;,
        ///     &quot;sourceName&quot;:&quot;agent-321-测试&quot;,
        ///     &quot;dataSource&quot;:&quot;&quot;,
        ///     &quot;userId&quot;:&quot;1672753***********&quot;
        /// },
        /// {
        ///     &quot;headers&quot;:{
        /// 
        ///     },
        ///     &quot;regionId&quot;:&quot;cn-zhangjiakou&quot;,
        ///     &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,
        ///     &quot;extras&quot;:{
        /// 
        ///     },
        ///     &quot;clusterId&quot;:&quot;c261a4f3200c446***********&quot;,
        ///     &quot;sourceName&quot;:&quot;zaifeng-cardinality-01&quot;,
        ///     &quot;dataSource&quot;:&quot;&quot;,
        ///     &quot;userId&quot;:&quot;1672753***********&quot;
        /// }
        /// </c></pre>
        /// <para>]</para>
        /// </summary>
        [NameInMap("SubClustersJson")]
        [Validation(Required=false)]
        public string SubClustersJson { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;labelName&quot;:&quot;labelValue&quot;
        ///     },
        ///     {
        ///         &quot;testName&quot;:&quot;clusterA&quot;
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreatePrometheusInstanceRequestTags> Tags { get; set; }
        public class CreatePrometheusInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required when ClusterType is set to ecs or aliyun-cs for a managed ASK cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1*********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID. This parameter is required when ClusterType is set to ecs or aliyun-cs for a managed ASK cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-rpn**********</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
