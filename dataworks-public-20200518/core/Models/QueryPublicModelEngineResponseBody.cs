// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryPublicModelEngineResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned information about objects.
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ReturnValue { get; set; }

    }

}
