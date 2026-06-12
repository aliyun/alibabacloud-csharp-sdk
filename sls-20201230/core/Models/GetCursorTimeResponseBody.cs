// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCursorTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The server time that corresponds to the cursor. The value is a UNIX timestamp. A UNIX timestamp represents the number of seconds that have elapsed since 1970-01-01 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554260243</para>
        /// </summary>
        [NameInMap("cursor_time")]
        [Validation(Required=false)]
        public string CursorTime { get; set; }

    }

}
