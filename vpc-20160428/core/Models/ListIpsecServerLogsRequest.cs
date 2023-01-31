// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpsecServerLogsRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        [NameInMap("IpsecServerId")]
        [Validation(Required=false)]
        public string IpsecServerId { get; set; }

        [NameInMap("MinutePeriod")]
        [Validation(Required=false)]
        public int? MinutePeriod { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
