// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            [NameInMap("ApplicableOperations")]
            [Validation(Required=false)]
            public List<string> ApplicableOperations { get; set; }

            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public long? Concurrency { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NluServiceParamsJson")]
            [Validation(Required=false)]
            public string NluServiceParamsJson { get; set; }

            [NameInMap("Numbers")]
            [Validation(Required=false)]
            public List<string> Numbers { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnionInstanceId")]
            [Validation(Required=false)]
            public string UnionInstanceId { get; set; }

            [NameInMap("UnionSource")]
            [Validation(Required=false)]
            public string UnionSource { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
