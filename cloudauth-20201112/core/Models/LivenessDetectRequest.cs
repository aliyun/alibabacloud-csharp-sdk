/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class LivenessDetectRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("MediaCategory")]
        [Validation(Required=false)]
        public string MediaCategory { get; set; }

        [NameInMap("MediaUrl")]
        [Validation(Required=false)]
        public string MediaUrl { get; set; }

        [NameInMap("MediaFile")]
        [Validation(Required=false)]
        public string MediaFile { get; set; }

    }

}
