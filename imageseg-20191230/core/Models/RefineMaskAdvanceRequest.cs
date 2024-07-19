// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class RefineMaskAdvanceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaskImageURL")]
        [Validation(Required=false)]
        public Stream MaskImageURLObject { get; set; }

    }

}
