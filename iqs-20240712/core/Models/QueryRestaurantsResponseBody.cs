// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class QueryRestaurantsResponseBody : TeaModel {
        [NameInMap("queryResult")]
        [Validation(Required=false)]
        public QueryResult QueryResult { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D78E16C0-4D44-5065-BFF7-127F7859F687</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
