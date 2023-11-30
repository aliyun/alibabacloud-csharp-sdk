// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListMyGroupDriveResponseBody : TeaModel {
        /// <summary>
        /// The information about the team drives.
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<Drive> Items { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If next_marker is empty, no next page exists.
        /// </summary>
        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
