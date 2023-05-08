// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventExportInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the export task.
        /// 
        /// > You can call the [ExportSuspEvents](~~ExportSuspEvents~~) operation to query the ID.
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public int? ExportId { get; set; }

    }

}
