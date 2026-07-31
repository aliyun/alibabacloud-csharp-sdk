// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteKeyPairsRequest : TeaModel {
        /// <summary>
        /// <para>The names of the SSH key pairs. The value is a JSON array of SSH key pair names. You can specify up to 100 SSH key pairs. Separate multiple names with commas (,).</para>
        /// <remarks>
        /// <para>Before you delete SSH key pairs, you can call <a href="https://help.aliyun.com/document_detail/51773.html">DescribeKeyPairs</a> to query existing key pairs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;TestKeyPairName-1&quot;, &quot;TestKeyPairName-2&quot;, … &quot;TestKeyPairName-100&quot;]</para>
        /// </summary>
        [NameInMap("KeyPairNames")]
        [Validation(Required=false)]
        public string KeyPairNames { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the SSH key pairs. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
