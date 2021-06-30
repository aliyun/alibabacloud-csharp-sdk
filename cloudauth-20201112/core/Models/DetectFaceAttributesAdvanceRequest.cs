// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class DetectFaceAttributesAdvanceRequest : TeaModel {
        [NameInMap("ImageFileObject")]
        [Validation(Required=true)]
        public Stream ImageFileObject { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
