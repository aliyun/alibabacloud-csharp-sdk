// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class QueryOrdersRequest : TeaModel {
        /// <summary>
        /// <para>Contains the query parameters to retrieve a list of main orders.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public OrderPageQuery Body { get; set; }

    }

}
