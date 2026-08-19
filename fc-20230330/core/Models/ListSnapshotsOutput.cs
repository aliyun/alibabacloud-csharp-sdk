// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListSnapshotsOutput : TeaModel {
        /// <summary>
        /// <para>The token used to retrieve the next page of results. This parameter is not returned if no more results are available.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of snapshots.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("snapshots")]
        [Validation(Required=false)]
        public List<Snapshot> Snapshots { get; set; }

    }

}
