// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceSharesRequest : TeaModel {
        [NameInMap("ResourceShareIds")]
        [Validation(Required=false)]
        public List<string> ResourceShareIds { get; set; }

        [NameInMap("ResourceOwner")]
        [Validation(Required=true)]
        public string ResourceOwner { get; set; }

        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

        [NameInMap("ResourceShareStatus")]
        [Validation(Required=false)]
        public string ResourceShareStatus { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
