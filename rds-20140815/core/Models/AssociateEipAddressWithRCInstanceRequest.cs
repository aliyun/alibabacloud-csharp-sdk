// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AssociateEipAddressWithRCInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP.</para>
        /// <remarks>
        /// <para>If you do not have an EIP, <a href="https://help.aliyun.com/document_detail/292841.html">create an EIP</a> first.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eip-bp166out2x4bpcf******</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The instance ID of the RDS Custom instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-i322y2t562oh7o******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the available regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
