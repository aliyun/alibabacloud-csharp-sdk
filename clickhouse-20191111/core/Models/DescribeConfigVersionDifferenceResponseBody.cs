// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigVersionDifferenceResponseBody : TeaModel {
        [NameInMap("NewConfigXML")]
        [Validation(Required=false)]
        public string NewConfigXML { get; set; }

        [NameInMap("OldConfigXML")]
        [Validation(Required=false)]
        public string OldConfigXML { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
