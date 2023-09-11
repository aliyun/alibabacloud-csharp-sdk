// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisDimensionsResponseBody : TeaModel {
        /// <summary>
        /// The names of the databases.
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The names of the database accounts.
        /// </summary>
        [NameInMap("UserNames")]
        [Validation(Required=false)]
        public List<string> UserNames { get; set; }

    }

}
