// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateAliasRequest : TeaModel {
        /// <summary>
        /// The alias of the CMK.
        /// 
        /// The alias must be 1 to 255 characters in length and must contain the prefix `alias/`. The alias cannot be prefixed with the reserved word `alias/acs`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

    }

}
