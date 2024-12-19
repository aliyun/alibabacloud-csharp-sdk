// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CancelActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>25C70FF3-D49B-594D-BECE-0DE2BA1D8BBB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2355,2352</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}
