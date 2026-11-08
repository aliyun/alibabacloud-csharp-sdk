// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHybridMonitorNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the metric namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud product metric repository.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the metric namespace.</para>
        /// <para>Format: The name can contain only lowercase letters, digits, and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The region where the monitoring data is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("NamespaceRegion")]
        [Validation(Required=false)]
        public string NamespaceRegion { get; set; }

        /// <summary>
        /// <para>The storage solution for monitoring data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aliyun_prometheus: Stores monitoring data in Prometheus.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about storage solutions for monitoring data, see <a href="https://help.aliyun.com/document_detail/2594921.html">Storage solutions for monitoring data in Hybrid Cloud Monitoring</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_prometheus</para>
        /// </summary>
        [NameInMap("NamespaceType")]
        [Validation(Required=false)]
        public string NamespaceType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The data storage duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cms.s1.large: Stores data for 15 days.</description></item>
        /// <item><description>cms.s1.xlarge: Stores data for 32 days.</description></item>
        /// <item><description>cms.s1.2xlarge: Stores data for 63 days.</description></item>
        /// <item><description>cms.s1.3xlarge (default): Stores data for 93 days.</description></item>
        /// <item><description>cms.s1.6xlarge: Stores data for 185 days.</description></item>
        /// <item><description>cms.s1.12xlarge: Stores data for 376 days.</description></item>
        /// </list>
        /// <para>For more information about the pricing of different storage durations, see the <b>Pricing</b> table in <a href="https://help.aliyun.com/document_detail/223532.html">Dashboard</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cms.s1.3xlarge</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
