// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DeltaGetLastCursorResponseBody : TeaModel {
        /// <summary>
        /// <para>The latest cursor of incremental information in the specified drive or synced folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

    }

}
