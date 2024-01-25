// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeNewPlayVideoPlaySessionListRequest : TeaModel {
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public string EndTimeStamp { get; set; }

        [NameInMap("InputStatus")]
        [Validation(Required=false)]
        public string InputStatus { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartTimeStamp")]
        [Validation(Required=false)]
        public string StartTimeStamp { get; set; }

        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

    }

}
