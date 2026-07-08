// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchCaptureRenderingInstanceScreenshotShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The image quality. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. A maximum of 100 instance IDs can be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RenderingInstanceIds")]
        [Validation(Required=false)]
        public string RenderingInstanceIdsShrink { get; set; }

    }

}
