// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DesensitizeDataResponseBody : TeaModel {
        /// <summary>
        /// The data returned after masking.
        /// </summary>
        [NameInMap("DesensitizeData")]
        [Validation(Required=false)]
        public string DesensitizeData { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
