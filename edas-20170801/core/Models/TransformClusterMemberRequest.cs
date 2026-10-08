// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class TransformClusterMemberRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the ECS instances. Separate multiple IDs with a comma (,).</para>
        /// <list type="bullet">
        /// <item><description><para>The instances must be in the same VPC as the target cluster.</para>
        /// </description></item>
        /// <item><description><para>An instance can belong to only one cluster at a time.</para>
        /// </description></item>
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
        /// <para>The logon password to set for the instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the target cluster.</para>
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
