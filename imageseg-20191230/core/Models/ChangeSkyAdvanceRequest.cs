// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class ChangeSkyAdvanceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReplaceImageURL")]
        [Validation(Required=false)]
        public Stream ReplaceImageURLObject { get; set; }

    }

}
