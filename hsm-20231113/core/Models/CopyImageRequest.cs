// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class CopyImageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-hafiudfahdd****</para>
        /// </summary>
        [NameInMap("ImageUid")]
        [Validation(Required=false)]
        public string ImageUid { get; set; }

        /// <summary>
        /// <para>The ID of the destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("TargetRegionId")]
        [Validation(Required=false)]
        public string TargetRegionId { get; set; }

    }

}
