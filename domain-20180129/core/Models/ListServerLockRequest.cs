// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ListServerLockRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndStartDate")]
        [Validation(Required=false)]
        public long? EndStartDate { get; set; }

        [NameInMap("BeginStartDate")]
        [Validation(Required=false)]
        public long? BeginStartDate { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LockProductId")]
        [Validation(Required=false)]
        public string LockProductId { get; set; }

        [NameInMap("ServerLockStatus")]
        [Validation(Required=false)]
        public int? ServerLockStatus { get; set; }

        [NameInMap("StartExpireDate")]
        [Validation(Required=false)]
        public long? StartExpireDate { get; set; }

        [NameInMap("EndExpireDate")]
        [Validation(Required=false)]
        public long? EndExpireDate { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
