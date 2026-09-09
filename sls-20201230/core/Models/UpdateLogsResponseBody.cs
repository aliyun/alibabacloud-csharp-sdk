// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of updated log rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("affectedRows")]
        [Validation(Required=false)]
        public int? AffectedRows { get; set; }

    }

}
