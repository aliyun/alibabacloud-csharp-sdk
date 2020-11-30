// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeDdosEventRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("PackId")]
        [Validation(Required=true)]
        public string PackId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public int? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public int? EndTime { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=true)]
        public int? PageNo { get; set; }

    }

}
