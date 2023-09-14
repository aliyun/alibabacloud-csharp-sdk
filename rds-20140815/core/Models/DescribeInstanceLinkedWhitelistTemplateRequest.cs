// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceLinkedWhitelistTemplateRequest : TeaModel {
        /// <summary>
        /// The instance name.
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        /// <summary>
        /// 资源组ID，可以为空。
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
