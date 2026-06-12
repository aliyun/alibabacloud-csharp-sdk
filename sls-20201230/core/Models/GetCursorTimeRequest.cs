// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCursorTimeRequest : TeaModel {
        /// <summary>
        /// <para>The cursor for which you want to obtain the timestamp. Call the <a href="https://help.aliyun.com/document_detail/2771314.html">GetCursor</a> operation to obtain a cursor.</para>
        /// <remarks>
        /// <para>If the value of the cursor is less than the begin cursor or greater than the end cursor, InvalidCursor is returned. If the shard contains no data, the current time is returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTU0NzQ3MDY4MjM3NjUxMzQ0Ng==</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

    }

}
