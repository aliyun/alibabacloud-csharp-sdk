// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiOperationRequest : TeaModel {
        /// <summary>
        /// <para>List of operation definitions.</para>
        /// </summary>
        [NameInMap("operations")]
        [Validation(Required=false)]
        public List<HttpApiOperation> Operations { get; set; }

    }

}
