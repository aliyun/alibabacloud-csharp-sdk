// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectBackupFilesRequest : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ActionDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> ActionDetail { get; set; }

        /// <summary>
        /// The download URL of the backup file for the ticket.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The parameters that are required to perform the operation. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
