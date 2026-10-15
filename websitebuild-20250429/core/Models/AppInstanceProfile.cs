// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppInstanceProfile : TeaModel {
        /// <summary>
        /// <para>The application type code. For example, PC_WebSite indicates a PC website.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC_WebSite</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The display name of the application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC Website</para>
        /// </summary>
        [NameInMap("ApplicationTypeText")]
        [Validation(Required=false)]
        public string ApplicationTypeText { get; set; }

        /// <summary>
        /// <para>The business identifier of the application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS_SITE_1</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The audit status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CaseAuditStatus")]
        [Validation(Required=false)]
        public string CaseAuditStatus { get; set; }

        /// <summary>
        /// <para>The listing status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("CaseShelfStatus")]
        [Validation(Required=false)]
        public string CaseShelfStatus { get; set; }

        /// <summary>
        /// <para>The ID of the ChatBI BuildSchemaIndex asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-1</para>
        /// </summary>
        [NameInMap("ChatbiTaskId")]
        [Validation(Required=false)]
        public string ChatbiTaskId { get; set; }

        /// <summary>
        /// <para>The status of the ChatBI BuildSchemaIndex task. Valid values: running, finish, and failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>finish</para>
        /// </summary>
        [NameInMap("ChatbiTaskStatus")]
        [Validation(Required=false)]
        public string ChatbiTaskStatus { get; set; }

        /// <summary>
        /// <para>The commodity code used when placing the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain_website_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The customer service contact information or description.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:support@example.com">support@example.com</a></para>
        /// </summary>
        [NameInMap("CustomerService")]
        [Validation(Required=false)]
        public string CustomerService { get; set; }

        /// <summary>
        /// <para>The deployment region code of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HongKong</para>
        /// </summary>
        [NameInMap("DeployArea")]
        [Validation(Required=false)]
        public string DeployArea { get; set; }

        /// <summary>
        /// <para>The ICP filing number bound to the custom domain name. Multiple filing numbers are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>京ICP备12345678号-1</para>
        /// </summary>
        [NameInMap("IcpbaNo")]
        [Validation(Required=false)]
        public string IcpbaNo { get; set; }

        /// <summary>
        /// <para>The dedicated server information. This field is computed in real time by DescribeAppInstance and is not populated in list API responses.</para>
        /// </summary>
        [NameInMap("IndependentDeployment")]
        [Validation(Required=false)]
        public AppInstanceProfileIndependentDeployment IndependentDeployment { get; set; }
        public class AppInstanceProfileIndependentDeployment : TeaModel {
            /// <summary>
            /// <para>Specifies whether a retry is allowed after the dedicated server fails to start.</para>
            /// </summary>
            [NameInMap("CanRetry")]
            [Validation(Required=false)]
            public bool? CanRetry { get; set; }

            /// <summary>
            /// <para>The deployment region code of the dedicated server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HongKong</para>
            /// </summary>
            [NameInMap("DeployArea")]
            [Validation(Required=false)]
            public string DeployArea { get; set; }

            /// <summary>
            /// <para>The DNS record type used when binding a domain name to the dedicated IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("DnsRecordType")]
            [Validation(Required=false)]
            public string DnsRecordType { get; set; }

            /// <summary>
            /// <para>The eligibility status of the dedicated server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>UPGRADE_REQUIRED: A version upgrade is required.</description></item>
            /// <item><description>AVAILABLE: The dedicated server can be started.</description></item>
            /// <item><description>UNAVAILABLE: The dedicated server is currently unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Eligibility")]
            [Validation(Required=false)]
            public string Eligibility { get; set; }

            /// <summary>
            /// <para>The status of the dedicated server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_ENABLED: Not started.</description></item>
            /// <item><description>ENABLING: Starting.</description></item>
            /// <item><description>ACTIVE: Started.</description></item>
            /// <item><description>FAILED: Failed to start.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            /// <summary>
            /// <para>The dedicated IP address assigned after the dedicated server is started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.0.113.10</para>
            /// </summary>
            [NameInMap("IndependentIp")]
            [Validation(Required=false)]
            public string IndependentIp { get; set; }

            /// <summary>
            /// <para>The display specification of the dedicated server. This does not represent the real-time resource usage of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2 vCPUs 2 GB</para>
            /// </summary>
            [NameInMap("ServerSpec")]
            [Validation(Required=false)]
            public string ServerSpec { get; set; }

            /// <summary>
            /// <para>The task ID for starting the dedicated server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the associated Lingxiao instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lx-1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current user is included in the ChatBI feature canary release whitelist.</para>
        /// </summary>
        [NameInMap("OpenChatBi")]
        [Validation(Required=false)]
        public bool? OpenChatBi { get; set; }

        /// <summary>
        /// <para>The time when the order was placed, in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-17 10:30:00</para>
        /// </summary>
        [NameInMap("OrdTime")]
        [Validation(Required=false)]
        public string OrdTime { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-1</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The time when the payment was made, in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-17 10:35:00</para>
        /// </summary>
        [NameInMap("PayTime")]
        [Validation(Required=false)]
        public string PayTime { get; set; }

        /// <summary>
        /// <para>The URL used to access the application preview page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/preview">https://example.com/preview</a></para>
        /// </summary>
        [NameInMap("PreviewUrl")]
        [Validation(Required=false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// <para>The SEO site configuration identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>seo-site-1</para>
        /// </summary>
        [NameInMap("SeoSite")]
        [Validation(Required=false)]
        public string SeoSite { get; set; }

        /// <summary>
        /// <para>The switch for the share rendering watermark. A value of 1 indicates enabled, and a value of 0 indicates disabled. This field is empty if not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShareRenderWatermark")]
        [Validation(Required=false)]
        public string ShareRenderWatermark { get; set; }

        /// <summary>
        /// <para>The site version code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Max_Edition</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public string SiteVersion { get; set; }

        /// <summary>
        /// <para>The display name of the site version, including the deployment region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Flagship Edition [Hong Kong]</para>
        /// </summary>
        [NameInMap("SiteVersionText")]
        [Validation(Required=false)]
        public string SiteVersionText { get; set; }

        /// <summary>
        /// <para>The identifier of the creation or synchronization source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKET_CLOUD_DREAM</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ETag identifier of the current application template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>etag-1</para>
        /// </summary>
        [NameInMap("TemplateEtag")]
        [Validation(Required=false)]
        public string TemplateEtag { get; set; }

        /// <summary>
        /// <para>The template ID used by the current application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl-1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
