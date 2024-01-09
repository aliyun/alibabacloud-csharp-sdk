/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20201210.Models
{
    public class CategoryParam : TeaModel {
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        [NameInMap("IsSelectFromDialog")]
        [Validation(Required=false)]
        public bool? IsSelectFromDialog { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

    }

}
