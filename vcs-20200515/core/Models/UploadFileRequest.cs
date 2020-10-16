// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UploadFileRequest : TeaModel {
        [NameInMap("FileType")]
        [Validation(Required=true)]
        public string FileType { get; set; }

        [NameInMap("MD5")]
        [Validation(Required=false)]
        public string MD5 { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=true)]
        public string CorpId { get; set; }

        [NameInMap("FileContent")]
        [Validation(Required=false)]
        public string FileContent { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=true)]
        public string FileName { get; set; }

        [NameInMap("FileAliasName")]
        [Validation(Required=false)]
        public string FileAliasName { get; set; }

        [NameInMap("DataSourceId")]
        [Validation(Required=true)]
        public string DataSourceId { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

    }

}
