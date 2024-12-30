// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class KnowledgeCategory : TeaModel {
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        [NameInMap("knowledge_base_id")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        [NameInMap("knowledge_base_name")]
        [Validation(Required=false)]
        public string KnowledgeBaseName { get; set; }

        [NameInMap("knowledge_category_id")]
        [Validation(Required=false)]
        public string KnowledgeCategoryId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("parent_knowledge_category_id")]
        [Validation(Required=false)]
        public string ParentKnowledgeCategoryId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
