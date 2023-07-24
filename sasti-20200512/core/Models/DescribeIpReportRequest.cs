// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sasti20200512.Models
{
    public class DescribeIpReportRequest : TeaModel {
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("ServiceLang")]
        [Validation(Required=false)]
        public string ServiceLang { get; set; }

    }

}
