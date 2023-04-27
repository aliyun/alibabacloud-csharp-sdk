// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLhTaskFlowAndScenarioRequest : TeaModel {
        /// <summary>
        /// The name of the user who creates the workspace.
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public long? SpaceId { get; set; }

        /// <summary>
        /// The ID of the workspace. You can call the [GetLhSpaceByName](~~424379~~) operation to obtain the workspace ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The user ID of the task flow owner.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
