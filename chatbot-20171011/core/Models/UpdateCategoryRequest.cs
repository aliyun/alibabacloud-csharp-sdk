// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class UpdateCategoryRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

    }

}
