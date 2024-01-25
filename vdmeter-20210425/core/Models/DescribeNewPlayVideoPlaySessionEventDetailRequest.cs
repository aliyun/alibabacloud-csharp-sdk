// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeNewPlayVideoPlaySessionEventDetailRequest : TeaModel {
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

        [NameInMap("InputStatus")]
        [Validation(Required=false)]
        public string InputStatus { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("VPS")]
        [Validation(Required=false)]
        public string VPS { get; set; }

    }

}
