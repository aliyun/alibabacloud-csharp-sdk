// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// The details of the master instance.
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public Cluster Cluster { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
