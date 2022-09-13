// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetShareLinkTokenRequest : TeaModel {
        [NameInMap("expire_sec")]
        [Validation(Required=false)]
        public int? ExpireSec { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

    }

}
