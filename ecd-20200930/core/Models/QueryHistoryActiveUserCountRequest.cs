// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryActiveUserCountRequest : TeaModel {
        /// <summary>
        /// <para>The date for which to query data, in YYYY-MM-DD format. Default: the previous day (T-1).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01</para>
        /// </summary>
        [NameInMap("DataDate")]
        [Validation(Required=false)]
        public string DataDate { get; set; }

    }

}
