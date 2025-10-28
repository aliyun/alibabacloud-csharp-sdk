// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertClusterMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster into which you want to import ECS instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3e3f77b-462e-<b><b>-</b></b>-bec8727a4dc8</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance that you want to import into the cluster. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2ze7s2v0b789k60p****</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The logon password of the ECS instance that you want to import into the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YourPassword</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
