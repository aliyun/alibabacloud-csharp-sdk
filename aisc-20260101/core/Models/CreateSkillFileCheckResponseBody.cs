// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateSkillFileCheckResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSkillFileCheckResponseBodyData Data { get; set; }
        public class CreateSkillFileCheckResponseBodyData : TeaModel {
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("RootTaskId")]
            [Validation(Required=false)]
            public string RootTaskId { get; set; }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            [NameInMap("UploadResults")]
            [Validation(Required=false)]
            public List<CreateSkillFileCheckResponseBodyDataUploadResults> UploadResults { get; set; }
            public class CreateSkillFileCheckResponseBodyDataUploadResults : TeaModel {
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("FileHash")]
                [Validation(Required=false)]
                public string FileHash { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("IdentifyId")]
                [Validation(Required=false)]
                public string IdentifyId { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
