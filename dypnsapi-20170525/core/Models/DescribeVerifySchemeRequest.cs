// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class DescribeVerifySchemeRequest : TeaModel {
        /// <summary>
        /// The user ID.
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public long? CustomerId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The service code.
        /// </summary>
        [NameInMap("SchemeCode")]
        [Validation(Required=false)]
        public string SchemeCode { get; set; }

    }

}
