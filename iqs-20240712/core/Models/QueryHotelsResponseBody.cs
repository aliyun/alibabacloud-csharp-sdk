// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class QueryHotelsResponseBody : TeaModel {
        [NameInMap("queryResult")]
        [Validation(Required=false)]
        public QueryResult QueryResult { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>78032F8B-0157-53F9-B1A8-3BD86ADE38D0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
