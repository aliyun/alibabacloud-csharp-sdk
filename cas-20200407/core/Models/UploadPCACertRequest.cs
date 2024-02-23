// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UploadPCACertRequest : TeaModel {
        /// <summary>
        /// <UploadPCACertResponse>
        ///     <RequestId>15C66C7B-671A-4297-9187-2C4477247A74</RequestId>
        /// </UploadPCACertResponse>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// UploadPCACert
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Uploads a private certificate to a certificate repository.
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// {
        ///     "RequestId": "15C66C7B-671A-4297-9187-2C4477247A74"
        /// }
        /// </summary>
        [NameInMap("WarehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
