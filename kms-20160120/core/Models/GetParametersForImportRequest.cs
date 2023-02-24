// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetParametersForImportRequest : TeaModel {
        /// <summary>
        /// The globally unique ID of the CMK.
        /// 
        /// >  You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The algorithm that is used to encrypt key material.
        /// </summary>
        [NameInMap("WrappingAlgorithm")]
        [Validation(Required=false)]
        public string WrappingAlgorithm { get; set; }

        /// <summary>
        /// The type of the public key that is used to encrypt key material.
        /// </summary>
        [NameInMap("WrappingKeySpec")]
        [Validation(Required=false)]
        public string WrappingKeySpec { get; set; }

    }

}
