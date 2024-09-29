// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyData Data { get; set; }
        public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried Prometheus instances.</para>
            /// </summary>
            [NameInMap("PrometheusInstances")]
            [Validation(Required=false)]
            public List<ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstances> PrometheusInstances { get; set; }
            public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstances : TeaModel {
                /// <summary>
                /// <para>The authorization token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ad32dxxxx</para>
                /// </summary>
                [NameInMap("AuthToken")]
                [Validation(Required=false)]
                public string AuthToken { get; set; }

                /// <summary>
                /// <para>The ID of the Prometheus instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c9d5dda1aeca64220853ace304baeb03d</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The name of the Prometheus instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prom1</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>remote-write: Prometheus instance for Remote Write</description></item>
                /// <item><description>ecs: Prometheus instances for ECS</description></item>
                /// <item><description>cloud-monitor: Prometheus instance for Alibaba Cloud services in the Chinese mainland</description></item>
                /// <item><description>cloud-product: Prometheus instance for Alibaba Cloud services outside the Chinese mainland</description></item>
                /// <item><description>global-view: global aggregation instance</description></item>
                /// <item><description>aliyun-cs: Prometheus instance for Container Service</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <para>The ID of the Grafana workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>grafana-rnggfvhlcdl6m71l**</para>
                /// </summary>
                [NameInMap("GrafanaInstanceId")]
                [Validation(Required=false)]
                public string GrafanaInstanceId { get; set; }

                /// <summary>
                /// <para>The public URL for the HTTP API.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/cn-beijing">http://cn-beijing.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/cn-beijing</a></para>
                /// </summary>
                [NameInMap("HttpApiInterUrl")]
                [Validation(Required=false)]
                public string HttpApiInterUrl { get; set; }

                /// <summary>
                /// <para>The internal URL for the HTTP API.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/cn-beijing">http://cn-beijing-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/cn-beijing</a></para>
                /// </summary>
                [NameInMap("HttpApiIntraUrl")]
                [Validation(Required=false)]
                public string HttpApiIntraUrl { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PREPAY: subscription</description></item>
                /// <item><description>POSTPAY: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAY</para>
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// <para>The public URL for Pushgateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v2">http://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v2</a></para>
                /// </summary>
                [NameInMap("PushGatewayInterUrl")]
                [Validation(Required=false)]
                public string PushGatewayInterUrl { get; set; }

                /// <summary>
                /// <para>The internal URL for Pushgateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing-intranet.arms.aliyuncs.com/prometheus/xxx/api/v2">http://cn-beijing-intranet.arms.aliyuncs.com/prometheus/xxx/api/v2</a></para>
                /// </summary>
                [NameInMap("PushGatewayIntraUrl")]
                [Validation(Required=false)]
                public string PushGatewayIntraUrl { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The public URL for remote read.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/api/v1/read">http://cn-beijing.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/api/v1/read</a></para>
                /// </summary>
                [NameInMap("RemoteReadInterUrl")]
                [Validation(Required=false)]
                public string RemoteReadInterUrl { get; set; }

                /// <summary>
                /// <para>The internal URL for remote read.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/api/v1/read">http://cn-beijing-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/xxx/api/v1/read</a></para>
                /// </summary>
                [NameInMap("RemoteReadIntraUrl")]
                [Validation(Required=false)]
                public string RemoteReadIntraUrl { get; set; }

                /// <summary>
                /// <para>The public URL for remote write.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v3/write">http://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v3/write</a></para>
                /// </summary>
                [NameInMap("RemoteWriteInterUrl")]
                [Validation(Required=false)]
                public string RemoteWriteInterUrl { get; set; }

                /// <summary>
                /// <para>The internal URL for remote write.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cn-beijing-intranet.arms.aliyuncs.com/prometheus/xxx/api/v3/write">http://cn-beijing-intranet.arms.aliyuncs.com/prometheus/xxx/api/v3/write</a></para>
                /// </summary>
                [NameInMap("RemoteWriteIntraUrl")]
                [Validation(Required=false)]
                public string RemoteWriteIntraUrl { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the Prometheus instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmz7nocpeidcy</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROMETHEUS</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-f8zd1toc10wmbi1v5rom</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The child instances of the global aggregation instance. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[ { &quot;headers&quot;: {}, &quot;regionId&quot;: &quot;cn-hangzhou&quot;, &quot;sourceType&quot;: &quot;AlibabaPrometheus&quot;, &quot;extras&quot;: {}, &quot;clusterId&quot;: &quot;c39a1048921e04fceb039db2fb\<em>\</em>\<em>\</em>&quot;, &quot;sourceName&quot;: &quot;arms-luyao-test&quot;, &quot;dataSource&quot;: &quot;&quot;, &quot;userId&quot;: &quot;167275301789\<em>\</em>\<em>\</em>&quot; }, { &quot;headers&quot;: {}, &quot;regionId&quot;: &quot;cn-beijing&quot;, &quot;sourceType&quot;: &quot;AlibabaPrometheus&quot;, &quot;extras&quot;: {}, &quot;clusterId&quot;: &quot;c6b6485496d5b400abde22cb47b5\<em>\</em>\<em>\</em>&quot;, &quot;sourceName&quot;: &quot;agent-321-test&quot;, &quot;dataSource&quot;: &quot;&quot;, &quot;userId&quot;: &quot;167275301789\<em>\</em>\<em>\</em>&quot; }, { &quot;headers&quot;: {}, &quot;regionId&quot;: &quot;cn-zhangjiakou&quot;, &quot;sourceType&quot;: &quot;AlibabaPrometheus&quot;, &quot;extras&quot;: {}, &quot;clusterId&quot;: &quot;c261a4f3200c446659133f1ade78\<em>\</em>\<em>\</em>&quot;, &quot;sourceName&quot;: &quot;zaifeng-cardinality-01&quot;, &quot;dataSource&quot;: &quot;&quot;, &quot;userId&quot;: &quot;167275301789\<em>\</em>\<em>\</em>&quot; } ]</para>
                /// </summary>
                [NameInMap("SubClustersJson")]
                [Validation(Required=false)]
                public string SubClustersJson { get; set; }

                /// <summary>
                /// <para>The list of tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstancesTags> Tags { get; set; }
                public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstancesTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ac-cus-tag-3</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>asg-2vc8qq7x89o11rus9uvu</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672753017899***</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-f8z73vcja1tqnw90aav5a</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbtp1fsm8mir18l8rl0u</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4789C3E9-A85A-524B-B97B-9D2B14BA06BC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
