// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteKeyMaterialRequest : TeaModel {
        /// <summary>
        /// The globally unique ID of the CMK.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

    }

}
