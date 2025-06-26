// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateAudioAsrTaskRequest : TeaModel {
        [NameInMap("input")]
        [Validation(Required=false)]
        public CreateAudioAsrTaskRequestInput Input { get; set; }
        public class CreateAudioAsrTaskRequestInput : TeaModel {
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
        public CreateAudioAsrTaskRequestOutput Output { get; set; }
        public class CreateAudioAsrTaskRequestOutput : TeaModel {
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
