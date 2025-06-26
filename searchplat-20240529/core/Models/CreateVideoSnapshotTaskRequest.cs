// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateVideoSnapshotTaskRequest : TeaModel {
        [NameInMap("input")]
        [Validation(Required=false)]
        public CreateVideoSnapshotTaskRequestInput Input { get; set; }
        public class CreateVideoSnapshotTaskRequestInput : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("file_name")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("oss")]
            [Validation(Required=false)]
            public string Oss { get; set; }

        }

        [NameInMap("output")]
        [Validation(Required=false)]
        public CreateVideoSnapshotTaskRequestOutput Output { get; set; }
        public class CreateVideoSnapshotTaskRequestOutput : TeaModel {
            [NameInMap("oss")]
            [Validation(Required=false)]
            public string Oss { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
