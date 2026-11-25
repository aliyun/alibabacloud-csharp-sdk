// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchCaptureRenderingInstanceScreenshotRequest : TeaModel {
        /// <summary>
        /// <para>The quality of the image. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. You can specify up to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RenderingInstanceIds")]
        [Validation(Required=false)]
        public List<string> RenderingInstanceIds { get; set; }

    }

}
