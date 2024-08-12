// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeWorkZonesRequest : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ZoneIdList")]
        [Validation(Required=false)]
        public List<string> ZoneIdList { get; set; }

        [NameInMap("ZoneNameList")]
        [Validation(Required=false)]
        public List<string> ZoneNameList { get; set; }

    }

}
