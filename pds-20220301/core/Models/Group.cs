// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Group : TeaModel {
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
