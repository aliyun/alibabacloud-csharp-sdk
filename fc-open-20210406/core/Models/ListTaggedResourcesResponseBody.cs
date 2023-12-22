// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListTaggedResourcesResponseBody : TeaModel {
        /// <summary>
        /// The token used to obtain more results. You do not need to provide this parameter in the first call. The tokens for subsequent queries are obtained from the returned results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about tagged services.
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<Resource> Resources { get; set; }

    }

}
