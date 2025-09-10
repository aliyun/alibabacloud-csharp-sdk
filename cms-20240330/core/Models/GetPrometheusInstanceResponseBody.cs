// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetPrometheusInstanceResponseBody : TeaModel {
        [NameInMap("prometheusInstance")]
        [Validation(Required=false)]
        public GetPrometheusInstanceResponseBodyPrometheusInstance PrometheusInstance { get; set; }
        public class GetPrometheusInstanceResponseBodyPrometheusInstance : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>readOnly</para>
            /// </summary>
            [NameInMap("accessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>165</para>
            /// </summary>
            [NameInMap("archiveDuration")]
            [Validation(Required=false)]
            public int? ArchiveDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("authFreeReadPolicy")]
            [Validation(Required=false)]
            public string AuthFreeReadPolicy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("authFreeWritePolicy")]
            [Validation(Required=false)]
            public string AuthFreeWritePolicy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eJwixxxxx</para>
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-10T02:07:53Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthFreeRead")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeRead { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthFreeWrite")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeWrite { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthToken")]
            [Validation(Required=false)]
            public bool? EnableAuthToken { get; set; }

            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://gnew.console.aliyun.com/dashboards/f/c49a80d2a551d4a20a8c4b996b0be4e52/xxxxxxx">https://gnew.console.aliyun.com/dashboards/f/c49a80d2a551d4a20a8c4b996b0be4e52/xxxxxxx</a></para>
            /// </summary>
            [NameInMap("folderUrl")]
            [Validation(Required=false)]
            public string FolderUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SHARED</para>
            /// </summary>
            [NameInMap("grafanaInstanceId")]
            [Validation(Required=false)]
            public string GrafanaInstanceId { get; set; }

            [NameInMap("grafanaInstanceName")]
            [Validation(Required=false)]
            public string GrafanaInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("httpApiInterUrl")]
            [Validation(Required=false)]
            public string HttpApiInterUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("httpApiIntraUrl")]
            [Validation(Required=false)]
            public string HttpApiIntraUrl { get; set; }

            /// <summary>
            /// <para>remote-write（Prometheus for Remote Write）</para>
            /// 
            /// <b>Example:</b>
            /// <para>e1</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prepaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("paymentTypeUpdateTime")]
            [Validation(Required=false)]
            public string PaymentTypeUpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NAS</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rw-524ada714221af267c73122af2e1</para>
            /// </summary>
            [NameInMap("prometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-prom-name</para>
            /// </summary>
            [NameInMap("prometheusInstanceName")]
            [Validation(Required=false)]
            public string PrometheusInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("pushGatewayInterUrl")]
            [Validation(Required=false)]
            public string PushGatewayInterUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("pushGatewayIntraUrl")]
            [Validation(Required=false)]
            public string PushGatewayIntraUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteReadInterUrl")]
            [Validation(Required=false)]
            public string RemoteReadInterUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://workspace-default-cms-1xxxxxxxxxx">https://workspace-default-cms-1xxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteReadIntraUrl")]
            [Validation(Required=false)]
            public string RemoteReadIntraUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://workspace-default-cms-xxxxxxxxxx">https://workspace-default-cms-xxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteWriteInterUrl")]
            [Validation(Required=false)]
            public string RemoteWriteInterUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://workspace-default-cms-xxxxxxxxxx">https://workspace-default-cms-xxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteWriteIntraUrl")]
            [Validation(Required=false)]
            public string RemoteWriteIntraUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-acfm3gn5i6bigbi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Prometheus</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("storageDuration")]
            [Validation(Required=false)]
            public int? StorageDuration { get; set; }

            [NameInMap("supportAuthTypes")]
            [Validation(Required=false)]
            public List<string> SupportAuthTypes { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetPrometheusInstanceResponseBodyPrometheusInstanceTags> Tags { get; set; }
            public class GetPrometheusInstanceResponseBodyPrometheusInstanceTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>openStorage</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>130303196111114281</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>170731234567</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rum-monitor-test-aysls-pub-cn-qingdao-monitor</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
