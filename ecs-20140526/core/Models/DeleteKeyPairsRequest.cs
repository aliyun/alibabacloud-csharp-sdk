// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteKeyPairsRequest : TeaModel {
        /// <summary>
        /// <para>The names of SSH key pairs. The value can be a JSON array that consists of up to 100 SSH key pair names. Separate the names with commas (,).</para>
        /// <remarks>
        /// <para> Before you delete an SSH key pair, you can call the <a href="https://help.aliyun.com/document_detail/51773.html">DescribeKeyPairs</a> operation to query existing key pairs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;skp-bp67acfmxazb41****&quot;, &quot;skp-bp67acfmxazb42****&quot;, … &quot;skp-bp67acfmxazb4p3***&quot;]</para>
        /// </summary>
        [NameInMap("KeyPairNames")]
        [Validation(Required=false)]
        public string KeyPairNames { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
