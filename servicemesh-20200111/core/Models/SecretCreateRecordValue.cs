/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class SecretCreateRecordValue : TeaModel {
        /// <summary>
        /// The result of creating the secret. Valid values:
        /// 
        /// *   `success`: The secret was created.
        /// *   `fail`: The secret failed to be created.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The ID of the cluster on the data plane.
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
