// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCursorTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The server time that is queried based on the cursor. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554260243</para>
        /// </summary>
        [NameInMap("cursor_time")]
        [Validation(Required=false)]
        public string CursorTime { get; set; }

    }

}
