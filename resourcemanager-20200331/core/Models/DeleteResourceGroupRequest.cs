// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DeleteResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group.
        /// 
        /// You can call the [ListResourceGroups](~~158855~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
