// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Does it require all child instances to be verified successfully before creating a GlobalView instance. The default is false, which means partial success is possible.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllSubClustersSuccess")]
        [Validation(Required=false)]
        public bool? AllSubClustersSuccess { get; set; }

        /// <summary>
        /// <para>The number of days for which data is automatically archived after the storage expires. Valid values: 60, 90, 180, and 365. 0 indicates that the data is not archived.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ArchiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        /// <summary>
        /// <para>The ID of the ACK cluster. This parameter is required if you set the ClusterType parameter to aliyun-cs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the created cluster. This parameter is required if you set the ClusterType parameter to remote-write or ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clusterNameOfTest</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The type of the Prometheus instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>remote-write: Prometheus instance for Remote Write</description></item>
        /// <item><description>ecs (unavailable): Prometheus instance for ECS</description></item>
        /// <item><description>global-view: Prometheus instance for GlobalView</description></item>
        /// <item><description>aliyun-cs: Prometheus instance for Container Service</description></item>
        /// <item><description>cloud-product (unavailable): Prometheus instance for Alibaba Cloud services</description></item>
        /// <item><description>cloud-monitor (unavailable): Prometheus instance for Hybrid Cloud Monitoring</description></item>
        /// <item><description>flink (unavailable): Prometheus instance for Flink</description></item>
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
        /// <para>The data storage duration. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The ID of the Grafana dedicated instance. This parameter is available if you set the ClusterType parameter to ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grafana-bp1*****</para>
        /// </summary>
        [NameInMap("GrafanaInstanceId")]
        [Validation(Required=false)]
        public string GrafanaInstanceId { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the region. If you use a Prometheus instance to monitor an Alibaba Cloud service in China, this parameter must be set to cn-shanghai.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the custom resource group. You can configure this parameter to bind the instance to the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the security group. This parameter is required if you set the ClusterType parameter to ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1********</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>JSON string for child instances of the globalView instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>When the clusterType is global view, this parameter needs to be passed: a list of information about the clusters that need to be aggregated.
        /// Example:
        /// [
        ///   {
        ///     &quot;Headers&quot;:{</para>
        /// <pre><c>},
        /// &quot;RegionId&quot;: &quot;cn hangzhou&quot;,
        /// &quot;SourceType&quot;: &quot;Alibaba Prometheus&quot;,
        /// &quot;Extras&quot;:{
        /// 
        /// },
        /// &quot;ClusterId&quot;: &quot;c39a1048921e04f ****************&quot;,
        /// &quot;SourceName&quot;: &quot;test1&quot;,
        /// &quot;DataSource&quot;: &quot;&quot;,
        /// &quot;UserId&quot;: &quot;1672753 ******************&quot;
        /// </c></pre>
        /// <para>  },
        ///   {
        ///     &quot;Headers&quot;:{</para>
        /// <pre><c>},
        /// &quot;RegionId&quot;: &quot;cn beijing&quot;,
        /// &quot;SourceType&quot;: &quot;Alibaba Prometheus&quot;,
        /// &quot;Extras&quot;:{
        /// 
        /// },
        /// &quot;ClusterId&quot;: &quot;c6b6485496d5b40 ****************&quot;,
        /// &quot;SourceName&quot;: &quot;test2&quot;,
        /// &quot;DataSource&quot;: &quot;&quot;,
        /// &quot;UserId&quot;: &quot;1672753 ******************&quot;
        /// </c></pre>
        /// <para>  },
        ///   {
        ///     &quot;Headers&quot;:{</para>
        /// <pre><c>},
        /// &quot;RegionId&quot;: &quot;cn zhangjiakou&quot;,
        /// &quot;SourceType&quot;: &quot;Alibaba Prometheus&quot;,
        /// &quot;Extras&quot;:{
        /// 
        /// },
        /// &quot;ClusterId&quot;: &quot;c261a4f3200c446 ****************&quot;,
        /// &quot;SourceName&quot;: &quot;test3&quot;,
        /// &quot;DataSource&quot;: &quot;&quot;,
        /// &quot;UserId&quot;: &quot;1672753 ******************&quot;
        /// </c></pre>
        /// <para>  }
        /// ]</para>
        /// </summary>
        [NameInMap("SubClustersJson")]
        [Validation(Required=false)]
        public string SubClustersJson { get; set; }

        /// <summary>
        /// <para>The tags of the instance. You can configure this parameter to manage tags for the instance.</para>
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
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required if you set the ClusterType parameter to ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1*********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of virtual private cloud (VPC). This parameter is required if you set the ClusterType parameter to ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-rpn**********</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
