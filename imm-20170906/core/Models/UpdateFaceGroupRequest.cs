// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class UpdateFaceGroupRequest : TeaModel {
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("GroupCoverFaceId")]
        [Validation(Required=false)]
        public string GroupCoverFaceId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("RemarksA")]
        [Validation(Required=false)]
        public string RemarksA { get; set; }

        [NameInMap("RemarksArrayA")]
        [Validation(Required=false)]
        public string RemarksArrayA { get; set; }

        [NameInMap("RemarksArrayB")]
        [Validation(Required=false)]
        public string RemarksArrayB { get; set; }

        [NameInMap("RemarksB")]
        [Validation(Required=false)]
        public string RemarksB { get; set; }

        [NameInMap("RemarksC")]
        [Validation(Required=false)]
        public string RemarksC { get; set; }

        [NameInMap("RemarksD")]
        [Validation(Required=false)]
        public string RemarksD { get; set; }

        [NameInMap("ResetItems")]
        [Validation(Required=false)]
        public string ResetItems { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

    }

}
