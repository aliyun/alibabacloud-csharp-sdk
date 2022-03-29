// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeUserDevicesResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeUserDevicesResponseBodyList> List { get; set; }
        public class DescribeUserDevicesResponseBodyList : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("EdgeNodeName")]
            [Validation(Required=false)]
            public string EdgeNodeName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MacAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            [NameInMap("MatrixId")]
            [Validation(Required=false)]
            public string MatrixId { get; set; }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("Specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
