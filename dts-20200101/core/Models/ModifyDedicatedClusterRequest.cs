// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDedicatedClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para> You must specify one of the <b>InstanceId</b> and <b>DedicatedClusterId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_h3fl1cs217sx952</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_test_001</para>
        /// </summary>
        [NameInMap("DedicatedClusterName")]
        [Validation(Required=false)]
        public string DedicatedClusterName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You must specify one of the <b>InstanceId</b> and <b>DedicatedClusterId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1162kryivb8****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The overcommit ratio. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("OversoldRatio")]
        [Validation(Required=false)]
        public int? OversoldRatio { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the Data Transmission Service (DTS) instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
