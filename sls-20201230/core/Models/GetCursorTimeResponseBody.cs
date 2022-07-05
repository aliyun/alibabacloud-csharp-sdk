// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCursorTimeResponseBody : TeaModel {
        /// <summary>
        /// Cursor的服务端时间。Unix时间戳格式，表示从1970-1-1 00:00:00 UTC计算起的秒数。
        /// </summary>
        [NameInMap("cursor_time")]
        [Validation(Required=false)]
        public string CursorTime { get; set; }

    }

}
