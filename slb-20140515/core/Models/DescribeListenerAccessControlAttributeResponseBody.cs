// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeListenerAccessControlAttributeResponseBody : TeaModel {
        [NameInMap("AccessControlStatus")]
        [Validation(Required=false)]
        public string AccessControlStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceItems")]
        [Validation(Required=false)]
        public string SourceItems { get; set; }

    }

}
