// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class CategoryListResult : TeaModel {
        /// <summary>
        /// <para>The category collection.</para>
        /// </summary>
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D1FC14F-CE54-1A1F-A322-D6DC87D49AFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
