// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListSpanNamesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The span names.
        /// </summary>
        [NameInMap("SpanNames")]
        [Validation(Required=false)]
        public ListSpanNamesResponseBodySpanNames SpanNames { get; set; }
        public class ListSpanNamesResponseBodySpanNames : TeaModel {
            [NameInMap("SpanName")]
            [Validation(Required=false)]
            public List<string> SpanName { get; set; }

        }

    }

}
