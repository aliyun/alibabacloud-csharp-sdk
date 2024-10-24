// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CancelActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>Batch cancellation task IDs, separated by English commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>188****,188****,188****</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A807C95D-410C-5BB5-96C0-C6E09F2C3D36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
