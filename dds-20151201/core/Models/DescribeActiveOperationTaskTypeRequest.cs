// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTaskTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return historical O\&M tasks. Valid values:
        /// 
        /// *   **0** (default): The system returns only pending O\&M tasks.
        /// *   **1**: The system returns historical O\&M tasks.
        /// </summary>
        [NameInMap("IsHistory")]
        [Validation(Required=false)]
        public int? IsHistory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The resource group ID. You can call the [DescribeSecurityGroupConfiguration](~~146130~~) operation to query the resource group ID.
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

    }

}
