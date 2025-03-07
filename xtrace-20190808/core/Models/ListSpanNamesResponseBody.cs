// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListSpanNamesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E2B6A4C-6B83-4062-8B6F-AEEC1F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The span names.</para>
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
