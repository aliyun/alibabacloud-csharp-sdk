// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateCategoryRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

    }

}
