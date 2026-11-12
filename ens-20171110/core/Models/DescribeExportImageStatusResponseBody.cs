// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeExportImageStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The image export status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Exporting: The image is being exported.</description></item>
        /// <item><description>Exported: The image is exported.</description></item>
        /// <item><description>ExportError: An error occurred during the image export.</description></item>
        /// <item><description>Unexported: The image is not exported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exporting</para>
        /// </summary>
        [NameInMap("ImageExportStatus")]
        [Validation(Required=false)]
        public string ImageExportStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14BBB3A0-3DBE-54F5-AEC8-01D3F6B1EBE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
