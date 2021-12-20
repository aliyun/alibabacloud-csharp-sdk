// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateUploadOSSFileJobShrinkRequest : TeaModel {
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileSource")]
        [Validation(Required=false)]
        public string FileSource { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("UploadTarget")]
        [Validation(Required=false)]
        public string UploadTargetShrink { get; set; }

    }

}
