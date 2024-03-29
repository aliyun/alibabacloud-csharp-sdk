// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunTriggerNodeRequest : TeaModel {
        /// <summary>
        /// The ID of the DataWorks workspace to which the manually triggered node belongs. You can call the [ListProjects](~~178393~~) operation to query the ID.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// The data timestamp of the manually triggered node instance.
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

        /// <summary>
        /// The scheduled time to run the manually triggered node. Set the value to a 13-digit timestamp in milliseconds.
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public long? CycleTime { get; set; }

        /// <summary>
        /// The ID of the manually triggered node. You can call the [ListNodes](~~173979~~) operation to query the ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

    }

}
