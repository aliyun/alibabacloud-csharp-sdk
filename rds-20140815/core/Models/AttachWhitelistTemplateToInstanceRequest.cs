// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AttachWhitelistTemplateToInstanceRequest : TeaModel {
        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        /// <summary>
        /// The ID of the resource group. For more information about resource groups, see Resource groups.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the whitelist template. You can call the DescribeAllWhitelistTemplate operation to obtain the ID of the whitelist template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

    }

}
