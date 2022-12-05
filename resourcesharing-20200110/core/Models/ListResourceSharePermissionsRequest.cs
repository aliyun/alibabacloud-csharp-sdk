// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceSharePermissionsRequest : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public string ResourceOwner { get; set; }

        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

    }

}
