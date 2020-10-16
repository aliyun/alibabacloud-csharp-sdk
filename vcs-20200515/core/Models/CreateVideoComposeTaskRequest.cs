// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateVideoComposeTaskRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=true)]
        public string CorpId { get; set; }

        [NameInMap("BucketName")]
        [Validation(Required=true)]
        public string BucketName { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("ImageFileNames")]
        [Validation(Required=true)]
        public string ImageFileNames { get; set; }

        [NameInMap("AudioFileName")]
        [Validation(Required=true)]
        public string AudioFileName { get; set; }

        [NameInMap("ImageParameters")]
        [Validation(Required=true)]
        public string ImageParameters { get; set; }

        [NameInMap("VideoFormat")]
        [Validation(Required=false)]
        public string VideoFormat { get; set; }

        [NameInMap("VideoFrameRate")]
        [Validation(Required=false)]
        public int? VideoFrameRate { get; set; }

    }

}
