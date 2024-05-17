/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkedmallRetrieval20240501.Models
{
    public class AISearchQuery : TeaModel {
        [NameInMap("card")]
        [Validation(Required=false)]
        public string Card { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
