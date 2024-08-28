// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CloneServiceShrinkRequest : TeaModel {
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        /// <summary>
        /// The request body. For more information, see [CreateService](https://help.aliyun.com/document_detail/412086.html).
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
