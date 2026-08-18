// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListNodePoolComponentsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyun_3_x64_20G_container_optimized_alibase_20250629.vhd</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AliyunLinux3</para>
        /// </summary>
        [NameInMap("image_type")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;ecs.c6.xlarge&quot;]</para>
        /// </summary>
        [NameInMap("instance_types")]
        [Validation(Required=false)]
        public string InstanceTypesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>np1855b102ac434f5990d87b77a****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("nodepool_type")]
        [Validation(Required=false)]
        public string NodepoolType { get; set; }

    }

}
