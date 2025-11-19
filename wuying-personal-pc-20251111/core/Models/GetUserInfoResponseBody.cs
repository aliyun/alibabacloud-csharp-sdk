// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class GetUserInfoResponseBody : TeaModel {
        [NameInMap("AliyunId")]
        [Validation(Required=false)]
        public string AliyunId { get; set; }

        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UnionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
