// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class PublishAdvanceConfigRequest : TeaModel {
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("files")]
        [Validation(Required=false)]
        public List<PublishAdvanceConfigRequestFiles> Files { get; set; }
        public class PublishAdvanceConfigRequestFiles : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public PublishAdvanceConfigRequestFilesConfig Config { get; set; }
            public class PublishAdvanceConfigRequestFilesConfig : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("variables")]
                [Validation(Required=false)]
                public Dictionary<string, FilesConfigVariablesValue> Variables { get; set; }

            }

            [NameInMap("dirName")]
            [Validation(Required=false)]
            public string DirName { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("operateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            [NameInMap("parentFullPath")]
            [Validation(Required=false)]
            public string ParentFullPath { get; set; }

        }

    }

}
