// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class AddStorageVideoTaskResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public AddStorageVideoTaskResponseData Data { get; set; }
        public class AddStorageVideoTaskResponseData : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=true)]
            public string TaskId { get; set; }
        };

    }

}
