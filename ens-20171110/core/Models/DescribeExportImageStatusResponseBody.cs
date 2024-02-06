// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeExportImageStatusResponseBody : TeaModel {
        /// <summary>
        /// The export status of the image. Valid values:
        /// 
        /// *   Exporting
        /// *   Exported
        /// *   ExportError
        /// *   Unexported
        /// </summary>
        [NameInMap("ImageExportStatus")]
        [Validation(Required=false)]
        public string ImageExportStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
