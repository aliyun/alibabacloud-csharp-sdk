// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeKernelReleaseNotesRequest : TeaModel {
        /// <summary>
        /// The number of the minor database version. For example: **mongodb\_20180522\_0.4.8**.
        /// 
        /// *   If you specify this parameter, a list of version numbers later than the version specified is returned.
        /// *   If you do not specify this parameter, a list of all the version numbers is returned.
        /// </summary>
        [NameInMap("KernelVersion")]
        [Validation(Required=false)]
        public string KernelVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
