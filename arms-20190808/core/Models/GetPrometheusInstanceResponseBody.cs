// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful. If another status code is returned, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrometheusInstanceResponseBodyData Data { get; set; }
        public class GetPrometheusInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The permission type. Valid values: readWrite, readOnly, and httpReadOnly</para>
            /// 
            /// <b>Example:</b>
            /// <para>readWrite</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The number of days for which data is automatically archived after the storage duration expires. Valid values: 60, 90, 180, and 365. 0 indicates that the data is not archived.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("ArchiveDuration")]
            [Validation(Required=false)]
            public int? ArchiveDuration { get; set; }

            /// <summary>
            /// <para>The whitelist of IP addresses for which password-free read is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("AuthFreeReadPolicy")]
            [Validation(Required=false)]
            public string AuthFreeReadPolicy { get; set; }

            /// <summary>
            /// <para>The whitelist of IP addresses for which password-free write is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("AuthFreeWritePolicy")]
            [Validation(Required=false)]
            public string AuthFreeWritePolicy { get; set; }

            /// <summary>
            /// <para>The authorization token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GciOiJIUzI1NiJ9***</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>The ID of the Prometheus instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c589a1b8db05c4561aefbb898ca8fb1cf</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the monitoring object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prom1</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>remote-write: general-purpose Prometheus instance</description></item>
            /// <item><description>ecs: Prometheus instances for ECS</description></item>
            /// <item><description>cloud-monitor: Prometheus instance for Alibaba Cloud services in the Chinese mainland</description></item>
            /// <item><description>cloud-product: Prometheus instance for Alibaba Cloud services outside the Chinese mainland</description></item>
            /// <item><description>global-view: global aggregation instance</description></item>
            /// <item><description>aliyun-cs: Prometheus instance for Container Service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>remote-write</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The data storage status at the backend.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("DbInstanceStatus")]
            [Validation(Required=false)]
            public string DbInstanceStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether password-free read is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableAuthFreeRead")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeRead { get; set; }

            /// <summary>
            /// <para>Indicates whether password-free write is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableAuthFreeWrite")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeWrite { get; set; }

            /// <summary>
            /// <para>Indicates whether access token authentication is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAuthToken")]
            [Validation(Required=false)]
            public string EnableAuthToken { get; set; }

            /// <summary>
            /// <para>The extra information.</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }

            /// <summary>
            /// <para>The ID of the Grafana workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>grafana-rnggfvhlcdl6m71***</para>
            /// </summary>
            [NameInMap("GrafanaInstanceId")]
            [Validation(Required=false)]
            public string GrafanaInstanceId { get; set; }

            /// <summary>
            /// <para>The public URL for the HTTP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-beijing.arms.aliyuncs.com:9443/api/v1/prometheus/xxx">https://cn-beijing.arms.aliyuncs.com:9443/api/v1/prometheus/xxx</a></para>
            /// </summary>
            [NameInMap("HttpApiInterUrl")]
            [Validation(Required=false)]
            public string HttpApiInterUrl { get; set; }

            /// <summary>
            /// <para>The internal URL for the HTTP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://cn-beijing-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/xxx">http://cn-beijing-intranet.arms.aliyuncs.com:9090/api/v1/prometheus/xxx</a></para>
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
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The product to which the Prometheus instance belongs. Valid values: arms and cms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The public URL for Pushgateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v2">https://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v2</a></para>
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
            /// <para>cn-beijing</para>
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
            /// <para><a href="https://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v3/write">https://cn-beijing.arms.aliyuncs.com/prometheus/xxx/api/v3/write</a></para>
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
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2vezare****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the resource. Set the value to PROMETHEUS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROMETHEUS</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the security group. This parameter is returned only for Prometheus instances for ECS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-8vbdgmf4nraiqa9bx0jo</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The data storage duration. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("StorageDuration")]
            [Validation(Required=false)]
            public int? StorageDuration { get; set; }

            /// <summary>
            /// <para>The child instances of the Prometheus instance for GlobalView. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;headers&quot;:{},&quot;regionId&quot;:&quot;cn-hangzhou&quot;,&quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,&quot;extras&quot;:{},&quot;clusterId&quot;:&quot;c39a1048921e04fceb039db2fbb73\<em>\</em>\<em>&quot;,&quot;sourceName&quot;:&quot;arms-luyao-test&quot;,&quot;dataSource&quot;:&quot;&quot;,&quot;userId&quot;:&quot;167275301789\</em>\<em>\</em>&quot;},{&quot;headers&quot;:{},&quot;regionId&quot;:&quot;cn-beijing&quot;,&quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,&quot;extras&quot;:{},&quot;clusterId&quot;:&quot;c6b6485496d5b400abde22cb47b5\<em>\</em>\<em>\</em>&quot;,&quot;sourceName&quot;:&quot;agent-321-test&quot;,&quot;dataSource&quot;:&quot;&quot;,&quot;userId&quot;:&quot;1672753017899\<em>\</em>\<em>&quot;},{&quot;headers&quot;:{},&quot;regionId&quot;:&quot;cn-zhangjiakou&quot;,&quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;,&quot;extras&quot;:{},&quot;clusterId&quot;:&quot;c261a4f3200c446659133f1ade789b15e&quot;,&quot;sourceName&quot;:&quot;zaifeng-cardinality-01&quot;,&quot;dataSource&quot;:&quot;&quot;,&quot;userId&quot;:&quot;167275301789\</em>\<em>\</em>&quot;}]</para>
            /// </summary>
            [NameInMap("SubClustersJson")]
            [Validation(Required=false)]
            public string SubClustersJson { get; set; }

            /// <summary>
            /// <para>The supported authentication types.</para>
            /// </summary>
            [NameInMap("SupportAuthTypes")]
            [Validation(Required=false)]
            public List<string> SupportAuthTypes { get; set; }

            /// <summary>
            /// <para>The tags of the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetPrometheusInstanceResponseBodyDataTags> Tags { get; set; }
            public class GetPrometheusInstanceResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tagValue1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167275301789****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID. This parameter is returned only for Prometheus instances for ECS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-f8z73vcja1tqnw90aav5a</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID. This parameter is returned only for Prometheus instances for ECS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-8vb02uk57qbcktqcvqqqj</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
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
        /// <para>52C422FD-6B43-524D-B8A1-A4693294318C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
