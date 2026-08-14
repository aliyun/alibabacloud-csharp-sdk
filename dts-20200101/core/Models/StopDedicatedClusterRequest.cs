// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StopDedicatedClusterRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You must specify either <b>InstanceId</b> or <b>DedicatedClusterId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_h3fl1cs217sx952</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_test_001</para>
        /// </summary>
        [NameInMap("DedicatedClusterName")]
        [Validation(Required=false)]
        public string DedicatedClusterName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You must specify either <b>InstanceId</b> or <b>DedicatedClusterId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1162kryivb8****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This is a global parameter that does not need to be specified for this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>资源组ID，全局参数，当前API无需传入。</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
