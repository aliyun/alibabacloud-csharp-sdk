// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKmsInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the KMS instance that you want to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

    }

}
