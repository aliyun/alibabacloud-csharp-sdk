// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateClusterAutoRenewRequest : TeaModel {
        /// <summary>
        /// <para>自动续费ECS实例列表。</para>
        /// </summary>
        [NameInMap("AutoRenewInstances")]
        [Validation(Required=false)]
        public List<AutoRenewInstance> AutoRenewInstances { get; set; }

        /// <summary>
        /// <para>集群是否自动续费。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ClusterAutoRenew")]
        [Validation(Required=false)]
        public bool? ClusterAutoRenew { get; set; }

        /// <summary>
        /// <para>集群自动续费时长。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterAutoRenewDuration")]
        [Validation(Required=false)]
        public int? ClusterAutoRenewDuration { get; set; }

        /// <summary>
        /// <para>集群续费时长单位。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monthly</para>
        /// </summary>
        [NameInMap("ClusterAutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string ClusterAutoRenewDurationUnit { get; set; }

        /// <summary>
        /// <para>集群ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-d6661c71139a****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>区域ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>续费所有ECS实例。</para>
        /// </summary>
        [NameInMap("RenewAllInstances")]
        [Validation(Required=false)]
        public bool? RenewAllInstances { get; set; }

    }

}
