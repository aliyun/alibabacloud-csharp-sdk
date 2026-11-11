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
        /// <para>PC website</para>
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
        /// <para>The commodity code of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain_website_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The contact information or instructions for customer service.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:support@example.com">support@example.com</a></para>
        /// </summary>
        [NameInMap("CustomerService")]
        [Validation(Required=false)]
        public string CustomerService { get; set; }

        /// <summary>
        /// <para>The code of the application deployment area.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HongKong</para>
        /// </summary>
        [NameInMap("DeployArea")]
        [Validation(Required=false)]
        public string DeployArea { get; set; }

        /// <summary>
        /// <para>The ICP filing number of the bound custom domain name. Separate multiple ICP filing numbers with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>京ICP备12345678号-1</para>
        /// </summary>
        [NameInMap("IcpbaNo")]
        [Validation(Required=false)]
        public string IcpbaNo { get; set; }

        /// <summary>
        /// <para>The independent server information. This information is computed in real time by DescribeAppInstance and is not populated in list operations.</para>
        /// </summary>
        [NameInMap("IndependentDeployment")]
        [Validation(Required=false)]
        public AppInstanceProfileIndependentDeployment IndependentDeployment { get; set; }
        public class AppInstanceProfileIndependentDeployment : TeaModel {
            /// <summary>
            /// <para>Specifies whether retries are allowed after the independent server fails to start.</para>
            /// </summary>
            [NameInMap("CanRetry")]
            [Validation(Required=false)]
            public bool? CanRetry { get; set; }

            /// <summary>
            /// <para>The code of the deployment area for the independent server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HongKong</para>
            /// </summary>
            [NameInMap("DeployArea")]
            [Validation(Required=false)]
            public string DeployArea { get; set; }

            /// <summary>
            /// <para>The DNS record type used when binding a domain name to an independent IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("DnsRecordType")]
            [Validation(Required=false)]
            public string DnsRecordType { get; set; }

            /// <summary>
            /// <para>The eligibility status of the independent server. Valid values: UPGRADE_REQUIRED (an upgrade is required), AVAILABLE (the feature can be enabled), and UNAVAILABLE (the feature is currently unavailable).</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Eligibility")]
            [Validation(Required=false)]
            public string Eligibility { get; set; }

            /// <summary>
            /// <para>The status of the independent server. Valid values: NOT_ENABLED (not enabled), ENABLING (enabling), ACTIVE (enabled), and FAILED (failed to enable).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            /// <summary>
            /// <para>The independent IP address assigned after the independent server is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.0.113.10</para>
            /// </summary>
            [NameInMap("IndependentIp")]
            [Validation(Required=false)]
            public string IndependentIp { get; set; }

            /// <summary>
            /// <para>The unified display specification of the independent server, which does not represent the real-time resource usage of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2 vCPUs and 2 GB</para>
            /// </summary>
            [NameInMap("ServerSpec")]
            [Validation(Required=false)]
            public string ServerSpec { get; set; }

            /// <summary>
            /// <para>The ID of the task to enable the independent server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The associated Lingxiao instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lx-1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the current user is included in the canary release whitelist for the ChatBI feature.</para>
        /// </summary>
        [NameInMap("OpenChatBi")]
        [Validation(Required=false)]
        public bool? OpenChatBi { get; set; }

        /// <summary>
        /// <para>The time when the order was placed. The format is yyyy-MM-dd HH:mm:ss.</para>
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
        /// <para>The time when the payment was made. The format is yyyy-MM-dd HH:mm:ss.</para>
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
        /// <para>The configuration identifier of the SEO site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>seo-site-1</para>
        /// </summary>
        [NameInMap("SeoSite")]
        [Validation(Required=false)]
        public string SeoSite { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the share rendering watermark. Valid values: 1 (enabled) and 0 (disabled). If not configured, this parameter is empty.</para>
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
        /// <para>The display name of the site version, which includes the deployment area.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ultimate Edition [Hong Kong]</para>
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
        /// <para>The ID of the template used by the current application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl-1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The upgrade status of the instance. Valid values: DOING (upgrading), SUCC (upgraded successfully), and FAIL (upgrade failed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCC</para>
        /// </summary>
        [NameInMap("UpgradeStatus")]
        [Validation(Required=false)]
        public string UpgradeStatus { get; set; }

    }

}
