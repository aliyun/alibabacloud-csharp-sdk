// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpdateResourceGroupAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the instance that you want to transfer.
        /// 
        /// >  You can call the [DescribeDrdsInstances](~~139284~~) operation to view the details of the instances under the account, including the instance IDs.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the resource group that you want to specify.
        /// 
        /// >  You can call the [ListResourceGroups](~~158855~~) operation to view the details of the resource groups, including the resource group IDs.
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the instance you want to transfer is located.
        /// 
        /// >  You can call the [DescribeDrdsInstances](~~139284~~) operation to view the details of the instances under the account, including the region IDs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
