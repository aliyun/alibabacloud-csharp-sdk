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
    public class CompareFacesRequest : TeaModel {
        [NameInMap("SourceImageUrl")]
        [Validation(Required=false)]
        public string SourceImageUrl { get; set; }

        [NameInMap("SourceImageBase64")]
        [Validation(Required=false)]
        public string SourceImageBase64 { get; set; }

        [NameInMap("TargetImageUrl")]
        [Validation(Required=false)]
        public string TargetImageUrl { get; set; }

        [NameInMap("TargetImageBase64")]
        [Validation(Required=false)]
        public string TargetImageBase64 { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

    }

}
