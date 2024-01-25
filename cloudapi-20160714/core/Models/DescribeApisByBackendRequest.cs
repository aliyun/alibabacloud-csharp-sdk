// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByBackendRequest : TeaModel {
        /// <summary>
        /// The ID of the backend service.
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        /// <summary>
        /// The number of the current page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The environment to which the API is published. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **PRE**
        /// *   **TEST**
        /// 
        /// If you do not specify this parameter, APIs in the draft state are returned.
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
