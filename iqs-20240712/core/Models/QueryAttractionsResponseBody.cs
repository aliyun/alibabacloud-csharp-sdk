// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class QueryAttractionsResponseBody : TeaModel {
        [NameInMap("queryResult")]
        [Validation(Required=false)]
        public QueryResult QueryResult { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECB2144C-E277-5434-80E6-12D26678D364</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
