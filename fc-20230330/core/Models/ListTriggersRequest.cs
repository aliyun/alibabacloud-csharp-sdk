// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListTriggersRequest : TeaModel {
        /// <summary>
        /// The number of triggers returned.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The token for the next page.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The trigger name prefix.
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}
