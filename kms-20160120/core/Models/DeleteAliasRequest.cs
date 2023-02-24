// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteAliasRequest : TeaModel {
        /// <summary>
        /// The alias that you want to delete.
        /// 
        /// The value must be 1 to 255 characters in length and must include the alias/ prefix.
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

    }

}
