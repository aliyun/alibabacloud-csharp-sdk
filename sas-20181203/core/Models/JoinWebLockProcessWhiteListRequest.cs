// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class JoinWebLockProcessWhiteListRequest : TeaModel {
        /// <summary>
        /// The paths of the processes.
        /// </summary>
        [NameInMap("ProcessPaths")]
        [Validation(Required=false)]
        public List<string> ProcessPaths { get; set; }

        /// <summary>
        /// The UUIDs of the servers on which the processes run. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
