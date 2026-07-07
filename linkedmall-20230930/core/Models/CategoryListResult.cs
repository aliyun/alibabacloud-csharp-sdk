// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class CategoryListResult : TeaModel {
        /// <summary>
        /// <para>category collection</para>
        /// </summary>
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// <para>request ID</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
