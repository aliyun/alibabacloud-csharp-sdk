// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class UpdateSmsCodeLimitConfigRequest : TeaModel {
        [NameInMap("LimitDay")]
        [Validation(Required=false)]
        public int? LimitDay { get; set; }

        [NameInMap("LimitHour")]
        [Validation(Required=false)]
        public int? LimitHour { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LimitId")]
        [Validation(Required=false)]
        public long? LimitId { get; set; }

        [NameInMap("LimitMinute")]
        [Validation(Required=false)]
        public int? LimitMinute { get; set; }

        [NameInMap("LimitOther")]
        [Validation(Required=false)]
        public string LimitOther { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
