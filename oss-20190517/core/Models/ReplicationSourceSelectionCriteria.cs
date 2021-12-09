// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationSourceSelectionCriteria : TeaModel {
        /// <summary>
        /// A short description of SseKmsEncryptedObjects
        /// </summary>
        [NameInMap("SseKmsEncryptedObjects")]
        [Validation(Required=false)]
        public ReplicationSourceSelectionCriteriaSseKmsEncryptedObjects SseKmsEncryptedObjects { get; set; }
        public class ReplicationSourceSelectionCriteriaSseKmsEncryptedObjects : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

    }

}
