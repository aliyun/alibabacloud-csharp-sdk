// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class OfflineNodeRequest : TeaModel {
        /// <summary>
        /// The ID of the node. You can call the [ListNodes](~~173979~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can call the [ListProjects](~~178393~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
