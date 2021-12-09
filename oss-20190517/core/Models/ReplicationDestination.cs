// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationDestination : TeaModel {
        /// <summary>
        /// The destination bucket to which the data is replicated
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// The region in which the destination bucket is located
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// The link used to transfer data in CRR
        /// </summary>
        [NameInMap("TransferType")]
        [Validation(Required=false)]
        public string TransferType { get; set; }

    }

}
