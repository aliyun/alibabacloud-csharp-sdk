// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDashboardsByNameRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster. If the ClusterType parameter is not set to <c>cloud-product-prometheus</c> or <c>cms-enterprise-prometheus</c>, you must specify the ClusterId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc-prometheus</description></item>
        /// <item><description>cloud-product-prometheus</description></item>
        /// <item><description>cms-enterprise-prometheus</description></item>
        /// <item><description>ExternalKubernetes</description></item>
        /// <item><description>Ask</description></item>
        /// <item><description>Kubernetes</description></item>
        /// <item><description>ManagedKubernetes</description></item>
        /// <item><description>remote-write-prometheus</description></item>
        /// <item><description>GlobalViewV2</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud-product-prometheus</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The name of the dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas-ingress-url</para>
        /// </summary>
        [NameInMap("DashBoardName")]
        [Validation(Required=false)]
        public string DashBoardName { get; set; }

        /// <summary>
        /// <para>The version of the dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("DashBoardVersion")]
        [Validation(Required=false)]
        public string DashBoardVersion { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>loki</description></item>
        /// <item><description>prometheus</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>loki</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The name of the dashboard group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDAS</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the Grafana dashboard only in the Application Real-Time Monitoring Service (ARMS) console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyQuery")]
        [Validation(Required=false)]
        public bool? OnlyQuery { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
