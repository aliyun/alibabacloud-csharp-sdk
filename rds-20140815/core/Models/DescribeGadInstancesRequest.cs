// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeGadInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the single global active database cluster that you want to query.
        /// 
        /// *   If you leave this parameter empty, this operation returns the details about all global active database clusters that are created within your Alibaba Cloud account.
        /// *   If you specify this parameter, this operation returns the details about the single global active database cluster that you specify.
        /// 
        /// >  You can call this operation with this parameter left empty to query the details about all global active database clusters that are created within your Alibaba Cloud account. Then, you can call this operation again with this parameter specified to query the details about the single global active database cluster that you specify.
        /// </summary>
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        /// <summary>
        /// The ID of the region where the global active database clusters that you want to query reside. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
