// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class KnowledgeBase : TeaModel {
        [NameInMap("cover_uri")]
        [Validation(Required=false)]
        public string CoverUri { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("file_filter")]
        [Validation(Required=false)]
        public string FileFilter { get; set; }

        [NameInMap("knowledge_base_id")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        [NameInMap("link_rule_list")]
        [Validation(Required=false)]
        public List<LinkRule> LinkRuleList { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("owner_id")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("owner_name")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
