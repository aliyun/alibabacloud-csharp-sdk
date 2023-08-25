// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSparkTemplateFileIdsResponseBody : TeaModel {
        /// <summary>
        /// The IDs of Spark template files.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<long?> Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
