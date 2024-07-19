// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("indices")]
        [Validation(Required=false)]
        public string Indices { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("snapshot")]
        [Validation(Required=false)]
        public string Snapshot { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
