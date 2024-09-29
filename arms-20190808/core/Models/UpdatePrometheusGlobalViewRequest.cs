// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// <para>To edit a GlobalView aggregated instance, do you require all passed child instances to be verified successfully before creating a GlobalView instance (optional, default to false):</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllSubClustersSuccess")]
        [Validation(Required=false)]
        public bool? AllSubClustersSuccess { get; set; }

        /// <summary>
        /// <para>The ID of the Prometheus instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the global aggregation instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zyGlobalView</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The region ID of the global aggregation instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("MostRegionId")]
        [Validation(Required=false)]
        public string MostRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the Prometheus instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Prometheus instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The data sources of the Prometheus instance for GlobalView.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;headers&quot;:{ }, &quot;regionId&quot;:&quot;cn-hangzhou&quot;, &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;, &quot;extras&quot;:{ }, &quot;clusterId&quot;:&quot;c39a1048921e04f***********&quot;, &quot;sourceName&quot;:&quot;arms-luyao-test&quot;, &quot;dataSource&quot;:&quot;&quot;, &quot;userId&quot;:&quot;1672753***********&quot; }, { &quot;headers&quot;:{ }, &quot;regionId&quot;:&quot;cn-beijing&quot;, &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;, &quot;extras&quot;:{ }, &quot;clusterId&quot;:&quot;c6b6485496d5b40***********&quot;, &quot;sourceName&quot;:&quot;agent-321-test&quot;, &quot;dataSource&quot;:&quot;&quot;, &quot;userId&quot;:&quot;1672753***********&quot; }, { &quot;headers&quot;:{ }, &quot;regionId&quot;:&quot;cn-zhangjiakou&quot;, &quot;sourceType&quot;:&quot;AlibabaPrometheus&quot;, &quot;extras&quot;:{ }, &quot;clusterId&quot;:&quot;c261a4f3200c446***********&quot;, &quot;sourceName&quot;:&quot;zaifeng-cardinality-01&quot;, &quot;dataSource&quot;:&quot;&quot;, &quot;userId&quot;:&quot;1672753***********&quot; } ]</para>
        /// </summary>
        [NameInMap("SubClustersJson")]
        [Validation(Required=false)]
        public string SubClustersJson { get; set; }

    }

}
