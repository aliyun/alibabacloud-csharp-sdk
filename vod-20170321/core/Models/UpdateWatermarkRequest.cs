// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateWatermarkRequest : TeaModel {
        /// <summary>
        /// The name of the watermark. Only letters and digits are supported.
        /// *   The name can be up to 128 bytes in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The configurations such as the position and effect of the text watermark or image watermark. The value is a JSON-formatted string.
        /// > The value of this parameter varies with the watermark type. For more information about the data structure, see the "WatermarkConfig" section of the [Media processing parameters](~~98618~~) topic.
        /// </summary>
        [NameInMap("WatermarkConfig")]
        [Validation(Required=false)]
        public string WatermarkConfig { get; set; }

        /// <summary>
        /// The ID of the watermark.
        /// </summary>
        [NameInMap("WatermarkId")]
        [Validation(Required=false)]
        public string WatermarkId { get; set; }

    }

}
