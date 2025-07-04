// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetImageShrinkRequest : TeaModel {
        [NameInMap("AdditionalRegionIds")]
        [Validation(Required=false)]
        public string AdditionalRegionIdsShrink { get; set; }

        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>m-2ze74g5mvy4pjg*****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

    }

}
