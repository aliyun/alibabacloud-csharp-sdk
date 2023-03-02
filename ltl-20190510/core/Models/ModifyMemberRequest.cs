// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class ModifyMemberRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("BizChainId")]
        [Validation(Required=false)]
        public string BizChainId { get; set; }

        [NameInMap("MemberContact")]
        [Validation(Required=false)]
        public string MemberContact { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        [NameInMap("MemberPhone")]
        [Validation(Required=false)]
        public string MemberPhone { get; set; }

        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
