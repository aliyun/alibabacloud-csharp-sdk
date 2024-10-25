// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeExportImageStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The export status of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Exporting</description></item>
        /// <item><description>Exported</description></item>
        /// <item><description>ExportError</description></item>
        /// <item><description>Unexported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exporting</para>
        /// </summary>
        [NameInMap("ImageExportStatus")]
        [Validation(Required=false)]
        public string ImageExportStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14BBB3A0-3DBE-54F5-AEC8-01D3F6B1EBE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
