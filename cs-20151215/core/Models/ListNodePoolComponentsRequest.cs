// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListNodePoolComponentsRequest : TeaModel {
        /// <summary>
        /// <para>The image ID of the node pool. Either this parameter or image_type is required if nodepool_id is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_3_x64_20G_container_optimized_alibase_20250629.vhd</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image type of the node pool. Either this parameter or image_id is required if nodepool_id is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunLinux3</para>
        /// </summary>
        [NameInMap("image_type")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The instance types of the node pool. This parameter is required if nodepool_id is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ecs.c6.xlarge&quot;]</para>
        /// </summary>
        [NameInMap("instance_types")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Default value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_results")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c0a1c0f91c14c6****</para>
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The node pool ID. If you specify a node pool ID, the system queries the list of components available for the node pool and ignores other parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np1855b102ac434f5990d87b77a****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The node pool type. This parameter is required if nodepool_id is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("nodepool_type")]
        [Validation(Required=false)]
        public string NodepoolType { get; set; }

    }

}
