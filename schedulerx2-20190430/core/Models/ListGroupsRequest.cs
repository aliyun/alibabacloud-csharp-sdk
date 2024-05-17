// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListGroupsRequest : TeaModel {
        /// <summary>
        /// The name of the application group.
        /// </summary>
        [NameInMap("AppGroupName")]
        [Validation(Required=false)]
        public string AppGroupName { get; set; }

        /// <summary>
        /// The namespace ID. You can obtain the namespace ID on the **Namespace** page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The source of the namespace. This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
