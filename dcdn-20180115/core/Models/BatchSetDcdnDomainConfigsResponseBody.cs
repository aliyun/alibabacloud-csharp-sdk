// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnDomainConfigsResponseBody : TeaModel {
        /// <summary>
        /// > 
        /// *   You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,)
        /// *   You can call this operation up to 30 times per second per account.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
