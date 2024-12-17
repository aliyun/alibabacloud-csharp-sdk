// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CancelActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of O\&amp;M events that are canceled at a time. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1508850,1508310,1507849,1506274</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F16A51B0-436E-5B84-8326-A18AA150D1C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
