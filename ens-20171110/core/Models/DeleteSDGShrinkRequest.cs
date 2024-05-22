// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteSDGShrinkRequest : TeaModel {
        /// <summary>
        /// IDs of SDGs that you want to delete. You can delete a maximum of 10 SDGs at a time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGIdShrink { get; set; }

    }

}
