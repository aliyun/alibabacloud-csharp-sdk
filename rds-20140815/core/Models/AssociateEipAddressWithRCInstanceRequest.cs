// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AssociateEipAddressWithRCInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The EIP ID.</para>
        /// <remarks>
        /// <para> If no EIP is available, create an EIP. For more information, see <a href="https://help.aliyun.com/document_detail/292841.html">Create an EIP</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eip-bp166out2x4bpcf******</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-i322y2t562oh7o******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
