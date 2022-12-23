// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddCategoryResponseBody : TeaModel {
        /// <summary>
        /// The information about the video category.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public AddCategoryResponseBodyCategory Category { get; set; }
        public class AddCategoryResponseBodyCategory : TeaModel {
            /// <summary>
            /// The ID of the video category.
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// The name of the category.
            /// 
            /// - The value can be up to 64 bytes in length.
            /// - The string must be encoded in the UTF-8 format.
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// The level of the category. A value of **0** indicates a level 1 category.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// The ID of the parent category. The parent category ID of a level 1 category is **-1**.
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// The type of the category. Valid values:
            /// 
            /// - **default** (default): default category
            /// - **material**: material category
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
