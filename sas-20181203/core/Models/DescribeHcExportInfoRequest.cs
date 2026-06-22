// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHcExportInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the export task. Call the <a href="https://help.aliyun.com/document_detail/425092.html">ExportWarning</a> operation to obtain the task ID (<b>Id</b>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>443285</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

    }

}
