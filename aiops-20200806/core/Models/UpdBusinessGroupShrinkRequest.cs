// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdBusinessGroupShrinkRequest : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("BusinessGroupDesc")]
        [Validation(Required=false)]
        public string BusinessGroupDesc { get; set; }

        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        [NameInMap("BusinessGroupName")]
        [Validation(Required=false)]
        public string BusinessGroupName { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceListShrink { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        [NameInMap("UpdateUser")]
        [Validation(Required=false)]
        public string UpdateUser { get; set; }

    }

}
