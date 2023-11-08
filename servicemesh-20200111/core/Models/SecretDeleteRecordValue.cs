// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class SecretDeleteRecordValue : TeaModel {
        /// <summary>
        /// The result of deleting the secret. Valid values:
        /// 
        /// *   `success`: The secret was deleted.
        /// *   `fail`: The secret failed to be deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The error message returned when exceptions occur. Otherwise, an empty value is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
