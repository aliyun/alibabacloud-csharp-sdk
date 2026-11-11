// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EnsureSharedPrometheusInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a new instance is created by this call. The value is false if an existing instance is found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public bool? Created { get; set; }

        /// <summary>
        /// <para>The details of the shared Prometheus instance. The fields are the same as the prometheusInstance field in GetPrometheusInstance.</para>
        /// </summary>
        [NameInMap("prometheusInstance")]
        [Validation(Required=false)]
        public EnsureSharedPrometheusInstanceResponseBodyPrometheusInstance PrometheusInstance { get; set; }
        public class EnsureSharedPrometheusInstanceResponseBodyPrometheusInstance : TeaModel {
            /// <summary>
            /// <para>The access permissions of the instance. Valid values: readWrite, readOnly, and httpReadOnly.</para>
            /// 
            /// <b>Example:</b>
            /// <para>readWrite</para>
            /// </summary>
            [NameInMap("accessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The number of days for automatic archive retention after the storage expires. A value of 0 indicates no archiving, and 3650 indicates permanent retention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("archiveDuration")]
            [Validation(Required=false)]
            public int? ArchiveDuration { get; set; }

            /// <summary>
            /// <para>The IP address whitelist policy that allows access to the authentication-free read endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("authFreeReadPolicy")]
            [Validation(Required=false)]
            public string AuthFreeReadPolicy { get; set; }

            /// <summary>
            /// <para>The IP address whitelist policy that allows access to the authentication-free write endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("authFreeWritePolicy")]
            [Validation(Required=false)]
            public string AuthFreeWritePolicy { get; set; }

            /// <summary>
            /// <para>The authentication token of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-auth-token</para>
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The time is displayed in UTC+0 in the yyyy-MM-ddTHH:mmZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-11T06:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether authentication-free read is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableAuthFreeRead")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeRead { get; set; }

            /// <summary>
            /// <para>Indicates whether authentication-free write is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableAuthFreeWrite")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeWrite { get; set; }

            /// <summary>
            /// <para>Indicates whether authentication token-based authentication is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableAuthToken")]
            [Validation(Required=false)]
            public bool? EnableAuthToken { get; set; }

            /// <summary>
            /// <para>The extended information. This field is returned only for console requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;slsProject&quot;:&quot;proj-cms-cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }

            /// <summary>
            /// <para>The URL of the dashboard associated with the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://g.console.aliyun.com/folders/example">https://g.console.aliyun.com/folders/example</a></para>
            /// </summary>
            [NameInMap("folderUrl")]
            [Validation(Required=false)]
            public string FolderUrl { get; set; }

            /// <summary>
            /// <para>The ID of the bound managed Grafana instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>grafana-cn-hangzhou-example</para>
            /// </summary>
            [NameInMap("grafanaInstanceId")]
            [Validation(Required=false)]
            public string GrafanaInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the bound managed Grafana instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shared-grafana</para>
            /// </summary>
            [NameInMap("grafanaInstanceName")]
            [Validation(Required=false)]
            public string GrafanaInstanceName { get; set; }

            /// <summary>
            /// <para>The public endpoint of the Prometheus HTTP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1">https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1</a></para>
            /// </summary>
            [NameInMap("httpApiInterUrl")]
            [Validation(Required=false)]
            public string HttpApiInterUrl { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the Prometheus HTTP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1">http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1</a></para>
            /// </summary>
            [NameInMap("httpApiInternalUrl")]
            [Validation(Required=false)]
            public string HttpApiInternalUrl { get; set; }

            /// <summary>
            /// <para>The internal network endpoint of the Prometheus HTTP API.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1">https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1</a></para>
            /// </summary>
            [NameInMap("httpApiIntraUrl")]
            [Validation(Required=false)]
            public string HttpApiIntraUrl { get; set; }

            /// <summary>
            /// <para>The instance type. For a shared instance, the value is remote-write, which indicates Prometheus for Remote Write.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote-write</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The billing method. POSTPAY indicates pay-as-you-go billing based on the number of reported metrics, and POSTPAY_GB indicates pay-as-you-go billing based on the volume of written metrics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY_GB</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The time when the billing method of the instance was last modified. The time is in UTC+0 and formatted as yyyy-MM-ddTHH:mmZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-11T06:00Z</para>
            /// </summary>
            [NameInMap("paymentTypeUpdateTime")]
            [Validation(Required=false)]
            public string PaymentTypeUpdateTime { get; set; }

            /// <summary>
            /// <para>The product to which the instance belongs. Valid values: arms and cms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The ID of the Prometheus instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-8f3c1a2b4d5e6f70</para>
            /// </summary>
            [NameInMap("prometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Prometheus instance. For a workspace shared instance, the name is generated by the server in the RegionShare:{workspace}:{regionId} format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionShare:team-workspace:cn-hangzhou</para>
            /// </summary>
            [NameInMap("prometheusInstanceName")]
            [Validation(Required=false)]
            public string PrometheusInstanceName { get; set; }

            /// <summary>
            /// <para>The public endpoint of Pushgateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1/pushgateway">https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1/pushgateway</a></para>
            /// </summary>
            [NameInMap("pushGatewayInterUrl")]
            [Validation(Required=false)]
            public string PushGatewayInterUrl { get; set; }

            /// <summary>
            /// <para>The internal endpoint of Pushgateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1/pushgateway">http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1/pushgateway</a></para>
            /// </summary>
            [NameInMap("pushGatewayInternalUrl")]
            [Validation(Required=false)]
            public string PushGatewayInternalUrl { get; set; }

            /// <summary>
            /// <para>The internal network endpoint of Pushgateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1/pushgateway">https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1/pushgateway</a></para>
            /// </summary>
            [NameInMap("pushGatewayIntraUrl")]
            [Validation(Required=false)]
            public string PushGatewayIntraUrl { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The public endpoint of Remote Read.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1/read">https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1/read</a></para>
            /// </summary>
            [NameInMap("remoteReadInterUrl")]
            [Validation(Required=false)]
            public string RemoteReadInterUrl { get; set; }

            /// <summary>
            /// <para>The internal endpoint of Remote Read.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1/read">http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1/read</a></para>
            /// </summary>
            [NameInMap("remoteReadInternalUrl")]
            [Validation(Required=false)]
            public string RemoteReadInternalUrl { get; set; }

            /// <summary>
            /// <para>The internal network endpoint of Remote Read.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1/read">https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1/read</a></para>
            /// </summary>
            [NameInMap("remoteReadIntraUrl")]
            [Validation(Required=false)]
            public string RemoteReadIntraUrl { get; set; }

            /// <summary>
            /// <para>The public endpoint of Remote Write.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1/write">https://cn-hangzhou.arms.aliyuncs.com/prometheus/rw-example/api/v1/write</a></para>
            /// </summary>
            [NameInMap("remoteWriteInterUrl")]
            [Validation(Required=false)]
            public string RemoteWriteInterUrl { get; set; }

            /// <summary>
            /// <para>The internal endpoint of Remote Write.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1/write">http://prometheus.cn-hangzhou.aliyuncs.com/prometheus/rw-example/api/v1/write</a></para>
            /// </summary>
            [NameInMap("remoteWriteInternalUrl")]
            [Validation(Required=false)]
            public string RemoteWriteInternalUrl { get; set; }

            /// <summary>
            /// <para>The internal network endpoint of Remote Write.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1/write">https://cn-hangzhou-intranet.arms.aliyuncs.com/prometheus/rw-example/api/v1/write</a></para>
            /// </summary>
            [NameInMap("remoteWriteIntraUrl")]
            [Validation(Required=false)]
            public string RemoteWriteIntraUrl { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyexample</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource type. The value is fixed as PrometheusInstance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrometheusInstance</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The backend data storage status, such as Running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The metric storage duration in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("storageDuration")]
            [Validation(Required=false)]
            public int? StorageDuration { get; set; }

            /// <summary>
            /// <para>The Prometheus query cache and parallel query configurations.</para>
            /// </summary>
            [NameInMap("storeConfig")]
            [Validation(Required=false)]
            public PrometheusInstanceStoreConfig StoreConfig { get; set; }

            /// <summary>
            /// <para>The list of authentication and authorization types supported by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BasicAuth</para>
            /// </summary>
            [NameInMap("supportAuthTypes")]
            [Validation(Required=false)]
            public List<string> SupportAuthTypes { get; set; }

            /// <summary>
            /// <para>The instance tags. A workspace shared instance includes the system tag acs:cms:shareScope.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<EnsureSharedPrometheusInstanceResponseBodyPrometheusInstanceTags> Tags { get; set; }
            public class EnsureSharedPrometheusInstanceResponseBodyPrometheusInstanceTags : TeaModel {
                /// <summary>
                /// <para>The key of the instance tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:cms:shareScope</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the instance tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region:cn-hangzhou:team-workspace</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The version of the instance, such as V2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The name of the workspace to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team-workspace</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
