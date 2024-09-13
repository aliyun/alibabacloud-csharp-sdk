// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteSDGShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of the SDGs that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGIdShrink { get; set; }

    }

}
