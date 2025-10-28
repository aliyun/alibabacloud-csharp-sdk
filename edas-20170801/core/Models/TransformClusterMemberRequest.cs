// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class TransformClusterMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance that you want to import or migrate. Separate multiple IDs with commas (,).</para>
        /// <list type="bullet">
        /// <item><description>An instance may not belong to a cluster, but an instance can belong to only one cluster at most.</description></item>
        /// <item><description>The ECS instances and the destination cluster must be in the same virtual private cloud (VPC).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2ze7s2v0b789k60p****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The logon password of the ECS instance that you want to import or migrate to the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the destination cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3e3f77b-462e-<b><b>-</b></b>-bec8727a****</para>
        /// </summary>
        [NameInMap("TargetClusterId")]
        [Validation(Required=false)]
        public string TargetClusterId { get; set; }

    }

}
