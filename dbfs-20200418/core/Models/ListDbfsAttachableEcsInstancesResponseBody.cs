// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListDbfsAttachableEcsInstancesResponseBody : TeaModel {
        [NameInMap("EcsLabelInfo")]
        [Validation(Required=false)]
        public List<ListDbfsAttachableEcsInstancesResponseBodyEcsLabelInfo> EcsLabelInfo { get; set; }
        public class ListDbfsAttachableEcsInstancesResponseBodyEcsLabelInfo : TeaModel {
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
