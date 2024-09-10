// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBackupAutoConfigStatusResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBackupAutoConfigStatusResponseBodyData Data { get; set; }
        public class GetBackupAutoConfigStatusResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the anti-ransomware policy for servers can be automatically configured by the managed anti-ransomware feature. Valid values:
            /// 
            /// *   **false**
            /// *   **true**
            /// </summary>
            [NameInMap("CanConfigAuto")]
            [Validation(Required=false)]
            public bool? CanConfigAuto { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
