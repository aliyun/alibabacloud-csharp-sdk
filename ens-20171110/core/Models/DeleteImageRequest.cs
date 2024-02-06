// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteImageRequest : TeaModel {
        /// <summary>
        /// The ID of the image. You can specify only one image ID.
        /// 
        /// You can delete only custom images that you created.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

    }

}
