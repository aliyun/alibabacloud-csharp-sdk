// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForApplyQuickTransferOutOpenlyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D6CB3623-4726-4947-AC2B-2C6E673B447C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d3babb0a-c939-4c25-8c65-c47b65f5492a</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
