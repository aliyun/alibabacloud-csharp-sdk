// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateTempDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>069EB9B1-DE12-54B9-8C20-822****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The temporary instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub16****_rm-bp13****</para>
        /// </summary>
        [NameInMap("TempDBInstanceId")]
        [Validation(Required=false)]
        public string TempDBInstanceId { get; set; }

    }

}
