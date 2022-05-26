// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetEnrolledAccountRequest : TeaModel {
        /// <summary>
        /// 账号ID
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// RegionId
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
