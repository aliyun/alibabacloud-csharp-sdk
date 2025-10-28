// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteClusterMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52984524-<b><b>-</b></b>-85f2-a34b0e5bb521</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The member ID of the ECS instance that you want to remove from the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zej4i2jdf3****jigng</para>
        /// </summary>
        [NameInMap("ClusterMemberId")]
        [Validation(Required=false)]
        public string ClusterMemberId { get; set; }

    }

}
