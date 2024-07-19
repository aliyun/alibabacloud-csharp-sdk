// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class SegmentClothAdvanceRequest : TeaModel {
        [NameInMap("ClothClass")]
        [Validation(Required=false)]
        public List<string> ClothClass { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("OutMode")]
        [Validation(Required=false)]
        public long? OutMode { get; set; }

        [NameInMap("ReturnForm")]
        [Validation(Required=false)]
        public string ReturnForm { get; set; }

    }

}
