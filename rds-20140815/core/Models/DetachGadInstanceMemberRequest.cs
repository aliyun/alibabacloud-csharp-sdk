// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DetachGadInstanceMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the global active database cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gad-rm-bp1npi2j8********</para>
        /// </summary>
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the instance that serves as the unit node you want to remove. You can call the DescribeGadInstances query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1npi2j8********</para>
        /// </summary>
        [NameInMap("MemberInstanceName")]
        [Validation(Required=false)]
        public string MemberInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID of the central node. You can call the DescribeGadInstances operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call the DescribeDBInstanceAttribute operation to query the resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
