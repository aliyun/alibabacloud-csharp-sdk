// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ImageInsightsConfig : TeaModel {
        /// <summary>
        /// <para>The image content recognition Caption configuration.</para>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public ImageInsightsCaptionConfig Caption { get; set; }

    }

}
