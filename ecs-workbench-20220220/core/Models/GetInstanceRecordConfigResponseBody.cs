// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class GetInstanceRecordConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public GetInstanceRecordConfigResponseBodyRoot Root { get; set; }
        public class GetInstanceRecordConfigResponseBodyRoot : TeaModel {
            [NameInMap("ExpirationDays")]
            [Validation(Required=false)]
            public int? ExpirationDays { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("RecordStorageTarget")]
            [Validation(Required=false)]
            public string RecordStorageTarget { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
