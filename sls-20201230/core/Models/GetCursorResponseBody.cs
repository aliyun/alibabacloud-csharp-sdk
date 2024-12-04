// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCursorResponseBody : TeaModel {
        /// <summary>
        /// <para>The value of the cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTQ0NzI5OTYwNjg5NjYzMjM1Ng==</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

    }

}
