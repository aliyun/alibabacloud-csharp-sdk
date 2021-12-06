// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListDbfsAttachedEcsInstancesResponseBody : TeaModel {
        [NameInMap("EcsLabelInfo")]
        [Validation(Required=false)]
        public List<ListDbfsAttachedEcsInstancesResponseBodyEcsLabelInfo> EcsLabelInfo { get; set; }
        public class ListDbfsAttachedEcsInstancesResponseBodyEcsLabelInfo : TeaModel {
            [NameInMap("MountPoint")]
            [Validation(Required=false)]
            public string MountPoint { get; set; }

            [NameInMap("MountedTime")]
            [Validation(Required=false)]
            public string MountedTime { get; set; }

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
