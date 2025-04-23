// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCommunityImagesRequest : TeaModel {
        /// <summary>
        /// <para>The tag of the base operating system (BOS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS_7.2_64</para>
        /// </summary>
        [NameInMap("BaseOsTag")]
        [Validation(Required=false)]
        public string BaseOsTag { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. If the cluster supports multiple operating systems, all community images in the region where the cluster resides are queried.</para>
        /// <para>If you do not specify the cluster ID, the community images that are supported by all clusters are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the Elastic Compute Service (ECS) instance. If you do not specify the instance type, the community images that are supported by all instance types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.n1.tiny</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
