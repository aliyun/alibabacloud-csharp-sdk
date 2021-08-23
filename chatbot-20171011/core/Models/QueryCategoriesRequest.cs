// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class QueryCategoriesRequest : TeaModel {
        [NameInMap("ParentCategoryId")]
        [Validation(Required=false)]
        public long? ParentCategoryId { get; set; }

        [NameInMap("ShowChildrens")]
        [Validation(Required=false)]
        public bool? ShowChildrens { get; set; }

        [NameInMap("KnowledgeType")]
        [Validation(Required=false)]
        public long? KnowledgeType { get; set; }

    }

}
