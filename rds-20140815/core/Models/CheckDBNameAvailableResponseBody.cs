// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckDBNameAvailableResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// <remarks>
        /// <para>If only the request ID is returned, the database name is available. Otherwise, an error message is returned, indicating that the database name is duplicate or does not comply with naming conventions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6EF82B07-28D2-48D1-B5D6-7E78FED277C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
