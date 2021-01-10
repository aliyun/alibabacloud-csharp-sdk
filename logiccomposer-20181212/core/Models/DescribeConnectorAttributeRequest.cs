// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class DescribeConnectorAttributeRequest : TeaModel {
        [NameInMap("ConnectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("StepInfo")]
        [Validation(Required=false)]
        public string StepInfo { get; set; }

    }

}
