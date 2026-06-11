// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateSkillFileCheckRequest : TeaModel {
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<CreateSkillFileCheckRequestFiles> Files { get; set; }
        public class CreateSkillFileCheckRequestFiles : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

    }

}
