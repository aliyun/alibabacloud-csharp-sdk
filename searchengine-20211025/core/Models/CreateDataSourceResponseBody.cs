// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateDataSourceResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}