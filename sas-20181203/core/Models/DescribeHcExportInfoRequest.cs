// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHcExportInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the export task.</para>
        /// <remarks>
        /// <para>To obtain the task ID (<b>Id</b>), call the <a href="https://help.aliyun.com/document_detail/425092.html">ExportWarning</a> operation.
        /// This parameter is required. If you do not specify this parameter, the API returns HTTP 400 and the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>443285</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

    }

}
