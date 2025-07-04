// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RunRCCommandResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c-7d2a745b412b4601b2d47f6a768d****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-7d2a745b412b4601b2d47f6a768d****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>06B220E2-EAC5-4DBE-A1FC-1B62DB6A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
