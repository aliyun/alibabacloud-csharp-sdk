// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetPrometheusViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The view instance.</para>
        /// </summary>
        [NameInMap("prometheusView")]
        [Validation(Required=false)]
        public GetPrometheusViewResponseBodyPrometheusView PrometheusView { get; set; }
        public class GetPrometheusViewResponseBodyPrometheusView : TeaModel {
            /// <summary>
            /// <para>The password-free read policy. It supports IP address segments and VPC IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;SourceIp&quot;: [
            ///     &quot;192.168.1.0/24&quot;,
            ///     &quot;172.168.2.22&quot;
            ///   ],
            ///   &quot;SourceVpc&quot;: [
            ///     &quot;vpc-xx1&quot;,
            ///     &quot;vpc-xx2&quot;
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("authFreeReadPolicy")]
            [Validation(Required=false)]
            public string AuthFreeReadPolicy { get; set; }

            /// <summary>
            /// <para>The authToken string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eJxxxxxx</para>
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The time is in UTC and follows the yyyy-MM-ddTHH:mmZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10T02:07:53Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether password-free read is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthFreeRead")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeRead { get; set; }

            /// <summary>
            /// <para>Indicates whether authToken is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthToken")]
            [Validation(Required=false)]
            public bool? EnableAuthToken { get; set; }

            /// <summary>
            /// <para>The URL of the observability dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx">https://xxxx</a></para>
            /// </summary>
            [NameInMap("folderUrl")]
            [Validation(Required=false)]
            public string FolderUrl { get; set; }

            /// <summary>
            /// <para>The ID of the attached managed Grafana instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-xxx</para>
            /// </summary>
            [NameInMap("grafanaInstanceId")]
            [Validation(Required=false)]
            public string GrafanaInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the attached managed Grafana instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gxxx</para>
            /// </summary>
            [NameInMap("grafanaInstanceName")]
            [Validation(Required=false)]
            public string GrafanaInstanceName { get; set; }

            /// <summary>
            /// <para>The HTTP API endpoint for the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxxxxxx">http://xxxxxxxx</a></para>
            /// </summary>
            [NameInMap("httpApiInterUrl")]
            [Validation(Required=false)]
            public string HttpApiInterUrl { get; set; }

            /// <summary>
            /// <para>The HTTP API endpoint for the internal network.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxxxxxx">http://xxxxxxxx</a></para>
            /// </summary>
            [NameInMap("httpApiIntraUrl")]
            [Validation(Required=false)]
            public string HttpApiIntraUrl { get; set; }

            /// <summary>
            /// <para>The instance type. The value is fixed to prom-view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prom-view</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The billing method. The value is fixed to FREE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FREE</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The product to which the Prometheus instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>A list of Prometheus instances.</para>
            /// </summary>
            [NameInMap("prometheusInstances")]
            [Validation(Required=false)]
            public List<GetPrometheusViewResponseBodyPrometheusViewPrometheusInstances> PrometheusInstances { get; set; }
            public class GetPrometheusViewResponseBodyPrometheusViewPrometheusInstances : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rw-63549e054ff596a4149927961dff</para>
                /// </summary>
                [NameInMap("prometheusInstanceId")]
                [Validation(Required=false)]
                public string PrometheusInstanceId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-north-2-gov-1</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122xxxxx</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Prometheus view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>view-xxx</para>
            /// </summary>
            [NameInMap("prometheusViewId")]
            [Validation(Required=false)]
            public string PrometheusViewId { get; set; }

            /// <summary>
            /// <para>The name of the Prometheus view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>view1</para>
            /// </summary>
            [NameInMap("prometheusViewName")]
            [Validation(Required=false)]
            public string PrometheusViewName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The remote read URL for the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxx-cn-hangzhou.cn-hangzhou.log.aliyuncs.com/prometheus/workspace-default-cms-xxx-cn-hangzhou/xxx/api/v1/read">http://workspace-default-cms-xxx-cn-hangzhou.cn-hangzhou.log.aliyuncs.com/prometheus/workspace-default-cms-xxx-cn-hangzhou/xxx/api/v1/read</a></para>
            /// </summary>
            [NameInMap("remoteReadInterUrl")]
            [Validation(Required=false)]
            public string RemoteReadInterUrl { get; set; }

            /// <summary>
            /// <para>The remote read URL for the internal network.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxx-cn-hangzhou.cn-hangzhou-intranet.log.aliyuncs.com/prometheus/workspace-default-cms-xxx-cn-hangzhou/xxx/api/v1/read">http://workspace-default-cms-xxx-cn-hangzhou.cn-hangzhou-intranet.log.aliyuncs.com/prometheus/workspace-default-cms-xxx-cn-hangzhou/xxx/api/v1/read</a></para>
            /// </summary>
            [NameInMap("remoteReadIntraUrl")]
            [Validation(Required=false)]
            public string RemoteReadIntraUrl { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3gn5i6bigbi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The value is fixed to PrometheusView.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegistryModule</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the backend data storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending2Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The supported authentication types.</para>
            /// </summary>
            [NameInMap("supportAuthTypes")]
            [Validation(Required=false)]
            public List<string> SupportAuthTypes { get; set; }

            /// <summary>
            /// <para>The tags of the instance.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetPrometheusViewResponseBodyPrometheusViewTags> Tags { get; set; }
            public class GetPrometheusViewResponseBodyPrometheusViewTags : TeaModel {
                /// <summary>
                /// <para>The integration key for PagerDuty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global_score_series</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>371293199010092839</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11222</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The workspace to which the environment belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms-monitor-test-aysls-pub-cn-fuzhou-monitor</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
