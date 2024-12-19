// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>42CD2EF5-D77E-5AD4-961B-159330D98286</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111,22222</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}
