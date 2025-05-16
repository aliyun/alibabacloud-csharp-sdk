// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UpdateClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto scale-out for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.1.0</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto scale-in for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public string ClusterCustomConfigurationShrink { get; set; }

        /// <summary>
        /// <para>The URL that is used to download the post-processing script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-serverless-cluster-20240805</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <para>The client version. By default, the latest version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The post-processing script of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-serverless-cluster-20240805</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The idle duration of the compute nodes allowed by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleOut")]
        [Validation(Required=false)]
        public bool? EnableScaleOut { get; set; }

        /// <summary>
        /// <para>The scheduler specifications of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GrowInterval")]
        [Validation(Required=false)]
        public int? GrowInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the topology awareness feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IdleInterval")]
        [Validation(Required=false)]
        public int? IdleInterval { get; set; }

        /// <summary>
        /// <para>The interval at which the cluster is automatically scaled out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public int? MaxCoreCount { get; set; }

        /// <summary>
        /// <para>The arguments that are used to run the post-processing script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// <para>The monitoring details of the cluster.</para>
        /// </summary>
        [NameInMap("MonitorSpec")]
        [Validation(Required=false)]
        public string MonitorSpecShrink { get; set; }

        /// <summary>
        /// <para>The scheduler specifications of the cluster.</para>
        /// </summary>
        [NameInMap("SchedulerSpec")]
        [Validation(Required=false)]
        public string SchedulerSpecShrink { get; set; }

    }

}
