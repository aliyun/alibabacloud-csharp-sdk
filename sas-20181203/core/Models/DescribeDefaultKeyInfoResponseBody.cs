// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDefaultKeyInfoResponseBody : TeaModel {
        /// <summary>
        /// The domain names.
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public List<string> DomainList { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
