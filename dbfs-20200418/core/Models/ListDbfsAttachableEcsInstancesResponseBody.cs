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
