// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DetachGadInstanceMemberRequest : TeaModel {
        /// <summary>
        /// The ID of the global active database cluster.
        /// </summary>
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        /// <summary>
        /// The ID of the instance that serves as the unit node you want to remove. You can call the [DescribeGadInstances](~~330105~~) query the ID of the instance.
        /// </summary>
        [NameInMap("MemberInstanceName")]
        [Validation(Required=false)]
        public string MemberInstanceName { get; set; }

        /// <summary>
        /// The region ID of the central node. You can call the [DescribeGadInstances](~~330105~~) operation to query the information.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. You can call the [DescribeDBInstanceAttribute](~~610394~~) to obtain the ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
