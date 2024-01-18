// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListUsersAsyncRequest : TeaModel {
        /// <summary>
        /// The ID of the asynchronous task.
        /// </summary>
        [NameInMap("AsyncId")]
        [Validation(Required=false)]
        public string AsyncId { get; set; }

        /// <summary>
        /// The ID of the E-HPC cluster. You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The page number.\
        /// Pages start from page 1.\
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.\
        /// Valid values: 1 to 50.\
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
