// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyVersionResponseBody : TeaModel {
        /// <summary>
        /// The metadata of the version.
        /// </summary>
        [NameInMap("KeyVersion")]
        [Validation(Required=false)]
        public CreateKeyVersionResponseBodyKeyVersion KeyVersion { get; set; }
        public class CreateKeyVersionResponseBodyKeyVersion : TeaModel {
            /// <summary>
            /// The date and time when the version was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// The ID of the CMK. The ID must be globally unique.
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("KeyVersionId")]
            [Validation(Required=false)]
            public string KeyVersionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
