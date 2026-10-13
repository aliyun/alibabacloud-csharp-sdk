// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventExportInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the export task.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ExportSuspEvents~~">ExportSuspEvents</a> operation to export events and obtain this ID.</para>
        /// </remarks>
        /// <para>This parameter is required. If it is not provided, the API returns an HTTP 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public int? ExportId { get; set; }

    }

}
