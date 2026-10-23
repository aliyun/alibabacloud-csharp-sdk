// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostTypesRequest : TeaModel {
        /// <summary>
        /// <para>The dedicated host type. For more information, see <a href="https://help.aliyun.com/document_detail/68564.html">Dedicated host types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddh.sn1ne</para>
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

        /// <summary>
        /// <para>The ECS instance family supported by the dedicated host type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.sn1ne</para>
        /// </summary>
        [NameInMap("SupportedInstanceTypeFamily")]
        [Validation(Required=false)]
        public string SupportedInstanceTypeFamily { get; set; }

    }

}
