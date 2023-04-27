// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteInstanceRequest : TeaModel {
        /// <summary>
        /// The error code that is returned.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DeleteInstance**.
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// The system ID (SID) of the database instance. You can call the [ListInstances](~~141936~~) or [GetInstance](~~141567~~) operation to obtain the SID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
