/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class AdaptGameVersionRequest : TeaModel {
        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public string FrameRate { get; set; }

        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
