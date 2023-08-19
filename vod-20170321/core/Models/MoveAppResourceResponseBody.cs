// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class MoveAppResourceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the resource that failed to be migrated.
        /// </summary>
        [NameInMap("FailedResourceIds")]
        [Validation(Required=false)]
        public List<string> FailedResourceIds { get; set; }

        /// <summary>
        /// The ID of the resource that was not found.
        /// </summary>
        [NameInMap("NonExistResourceIds")]
        [Validation(Required=false)]
        public List<string> NonExistResourceIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
