// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetPrometheusInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the Prometheus instance.</para>
        /// </summary>
        [NameInMap("prometheusInstance")]
        [Validation(Required=false)]
        public GetPrometheusInstanceResponseBodyPrometheusInstance PrometheusInstance { get; set; }
        public class GetPrometheusInstanceResponseBodyPrometheusInstance : TeaModel {
            /// <summary>
            /// <para>Access type:
            /// readWrite, readOnly, httpReadOnly</para>
            /// 
            /// <b>Example:</b>
            /// <para>readOnly</para>
            /// </summary>
            [NameInMap("accessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>Number of days to automatically archive and save after storage expiration. 0 means no archiving, 3650 means permanent saving.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("archiveDuration")]
            [Validation(Required=false)]
            public int? ArchiveDuration { get; set; }

            /// <summary>
            /// <para>Password-free read policy (supports IP segments and VpcId).</para>
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
            /// <para>Password-free write policy (supports IP segments and VpcId).</para>
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
            [NameInMap("authFreeWritePolicy")]
            [Validation(Required=false)]
            public string AuthFreeWritePolicy { get; set; }

            /// <summary>
            /// <para>authToken string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eJwixxxxx</para>
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>Instance creation time, using UTC+0, formatted as yyyy-MM-ddTHH:mmZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10T02:07:53Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Whether to enable password-free reading.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthFreeRead")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeRead { get; set; }

            /// <summary>
            /// <para>Whether to enable password-free writing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthFreeWrite")]
            [Validation(Required=false)]
            public bool? EnableAuthFreeWrite { get; set; }

            /// <summary>
            /// <para>Whether to enable authentication token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAuthToken")]
            [Validation(Required=false)]
            public bool? EnableAuthToken { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// </summary>
            [NameInMap("extraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraInfo { get; set; }

            /// <summary>
            /// <para>URL of the visualization dashboard directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://gnew.console.aliyun.com/dashboards/f/c49a80d2a551d4a20a8c4b996b0be4e52/xxxxxxx">https://gnew.console.aliyun.com/dashboards/f/c49a80d2a551d4a20a8c4b996b0be4e52/xxxxxxx</a></para>
            /// </summary>
            [NameInMap("folderUrl")]
            [Validation(Required=false)]
            public string FolderUrl { get; set; }

            /// <summary>
            /// <para>ID of the managed Grafana instance that is bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHARED</para>
            /// </summary>
            [NameInMap("grafanaInstanceId")]
            [Validation(Required=false)]
            public string GrafanaInstanceId { get; set; }

            /// <summary>
            /// <para>Name of the managed Grafana instance that is bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>共享版</para>
            /// </summary>
            [NameInMap("grafanaInstanceName")]
            [Validation(Required=false)]
            public string GrafanaInstanceName { get; set; }

            /// <summary>
            /// <para>HTTP public network address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("httpApiInterUrl")]
            [Validation(Required=false)]
            public string HttpApiInterUrl { get; set; }

            /// <summary>
            /// <para>HTTP intranet address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("httpApiIntraUrl")]
            [Validation(Required=false)]
            public string HttpApiIntraUrl { get; set; }

            /// <summary>
            /// <para>Prometheus instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote-write</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Billing method:
            /// POSTPAY: Pay-as-you-go based on metric reporting volume.
            /// POSTPAY_GB: Pay-as-you-go based on metric write volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>Time when the billing method of the instance was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10T02:07:53Z</para>
            /// </summary>
            [NameInMap("paymentTypeUpdateTime")]
            [Validation(Required=false)]
            public string PaymentTypeUpdateTime { get; set; }

            /// <summary>
            /// <para>The product to which the Prometheus instance belongs (arms or cms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-524ada714221af267c73122af2e1</para>
            /// </summary>
            [NameInMap("prometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// <para>Instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-prom-name</para>
            /// </summary>
            [NameInMap("prometheusInstanceName")]
            [Validation(Required=false)]
            public string PrometheusInstanceName { get; set; }

            /// <summary>
            /// <para>Public network address of PushGateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("pushGatewayInterUrl")]
            [Validation(Required=false)]
            public string PushGatewayInterUrl { get; set; }

            /// <summary>
            /// <para>Intranet address of PushGateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("pushGatewayIntraUrl")]
            [Validation(Required=false)]
            public string PushGatewayIntraUrl { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Public network read address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workspace-default-cms-xxxxxxx">http://workspace-default-cms-xxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteReadInterUrl")]
            [Validation(Required=false)]
            public string RemoteReadInterUrl { get; set; }

            /// <summary>
            /// <para>Intranet read address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://workspace-default-cms-1xxxxxxxxxx">https://workspace-default-cms-1xxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteReadIntraUrl")]
            [Validation(Required=false)]
            public string RemoteReadIntraUrl { get; set; }

            /// <summary>
            /// <para>Public network write address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://workspace-default-cms-xxxxxxxxxx">https://workspace-default-cms-xxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteWriteInterUrl")]
            [Validation(Required=false)]
            public string RemoteWriteInterUrl { get; set; }

            /// <summary>
            /// <para>Intranet write address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://workspace-default-cms-xxxxxxxxxx">https://workspace-default-cms-xxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("remoteWriteIntraUrl")]
            [Validation(Required=false)]
            public string RemoteWriteIntraUrl { get; set; }

            /// <summary>
            /// <para>Resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm3gn5i6bigbi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Fixed value: PrometheusInstance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>Instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Storage duration (in days).</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("storageDuration")]
            [Validation(Required=false)]
            public int? StorageDuration { get; set; }

            /// <summary>
            /// <para>Supported authentication types.</para>
            /// </summary>
            [NameInMap("supportAuthTypes")]
            [Validation(Required=false)]
            public List<string> SupportAuthTypes { get; set; }

            /// <summary>
            /// <para>List of tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetPrometheusInstanceResponseBodyPrometheusInstanceTags> Tags { get; set; }
            public class GetPrometheusInstanceResponseBodyPrometheusInstanceTags : TeaModel {
                /// <summary>
                /// <para>Tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openStorage</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Matched value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>130303196111114281</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170731234567</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The workspace to which the Prometheus instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws1</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
