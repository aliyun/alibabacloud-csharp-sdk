// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACK Edge cluster in which the RDS Custom instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c463aaa89e2b84cacacfbf23c4867****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The node pool ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np31da1b38983f4511b490fc62108a****</para>
        /// </summary>
        [NameInMap("NodePoolId")]
        [Validation(Required=false)]
        public string NodePoolId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
