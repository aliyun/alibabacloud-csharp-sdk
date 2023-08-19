// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateCategoryRequest : TeaModel {
        /// <summary>
        /// The ID of the category.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The name of the category.
        /// 
        /// *   The value can be up to 64 bytes in length.
        /// *   The string must be encoded in the UTF-8 format.
        /// </summary>
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

    }

}
