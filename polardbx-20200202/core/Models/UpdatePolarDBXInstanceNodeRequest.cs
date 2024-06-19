// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpdatePolarDBXInstanceNodeRequest : TeaModel {
        [NameInMap("AddDNSpec")]
        [Validation(Required=false)]
        public string AddDNSpec { get; set; }

        [NameInMap("CNNodeCount")]
        [Validation(Required=false)]
        public string CNNodeCount { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DNNodeCount")]
        [Validation(Required=false)]
        public string DNNodeCount { get; set; }

        [NameInMap("DbInstanceNodeCount")]
        [Validation(Required=false)]
        public string DbInstanceNodeCount { get; set; }

        [NameInMap("DeleteDNIds")]
        [Validation(Required=false)]
        public string DeleteDNIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StoragePoolName")]
        [Validation(Required=false)]
        public string StoragePoolName { get; set; }

    }

}
