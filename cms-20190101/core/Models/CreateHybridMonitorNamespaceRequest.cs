// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHybridMonitorNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the namespace.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>The name can contain lowercase letters, digits, and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The region where the metric data is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("NamespaceRegion")]
        [Validation(Required=false)]
        public string NamespaceRegion { get; set; }

        /// <summary>
        /// <para>The storage scheme of metric data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>m_prom_user: The metric data is stored in Simple Log Service.</description></item>
        /// <item><description>m_prom_pool: The metric data is stored in the private storage space provided by CloudMonitor.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about the storage schemes of metric data, see <a href="https://help.aliyun.com/document_detail/2594921.html">Data storage schemes for Hybrid Cloud Monitoring</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>m_prometheus</para>
        /// </summary>
        [NameInMap("NamespaceType")]
        [Validation(Required=false)]
        public string NamespaceType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The data retention period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cms.s1.large (Retention Period 15 Days)</description></item>
        /// <item><description>cms.s1.xlarge (Retention Period 32 Days)</description></item>
        /// <item><description>cms.s1.2xlarge (Retention Period 63 Days)</description></item>
        /// <item><description>cms.s1.3xlarge (Retention Period 93 Days) (default)</description></item>
        /// <item><description>cms.s1.6xlarge (Retention Period 185 Days)</description></item>
        /// <item><description>cms.s1.12xlarge (Retention Period 367 Days)</description></item>
        /// </list>
        /// <para>For information about the pricing for different retention periods, see the <b>Pricing</b> section in <a href="https://help.aliyun.com/document_detail/223532.html">Billing of the dashboard feature</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cms.s1.3xlarge</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
