// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateResourceFileAdvanceRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("FileDescription")]
        [Validation(Required=false)]
        public string FileDescription { get; set; }

        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        [NameInMap("OriginResourceName")]
        [Validation(Required=false)]
        public string OriginResourceName { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("RegisterToCalcEngine")]
        [Validation(Required=false)]
        public bool? RegisterToCalcEngine { get; set; }

        [NameInMap("ResourceFile")]
        [Validation(Required=false)]
        public Stream ResourceFileObject { get; set; }

        [NameInMap("StorageURL")]
        [Validation(Required=false)]
        public string StorageURL { get; set; }

        [NameInMap("UploadMode")]
        [Validation(Required=false)]
        public bool? UploadMode { get; set; }

    }

}
