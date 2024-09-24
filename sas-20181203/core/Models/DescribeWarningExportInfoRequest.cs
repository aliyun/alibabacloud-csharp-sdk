// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWarningExportInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the export task.</para>
        /// <remarks>
        /// <para> You can can call the <a href="~~ExportWarning~~">ExportWarning</a> operation to query the IDs of export tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14356</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

    }

}
