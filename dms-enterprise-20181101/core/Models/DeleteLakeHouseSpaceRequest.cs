// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteLakeHouseSpaceRequest : TeaModel {
        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public long? SpaceId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
