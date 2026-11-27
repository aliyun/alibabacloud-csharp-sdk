// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CancelSqlPatternCompareReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The time of the first cancellation. The time is displayed in UTC in the yyyy-MM-ddTHH:mmZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T01:06Z</para>
        /// </summary>
        [NameInMap("CancelTime")]
        [Validation(Required=false)]
        public string CancelTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the report is canceled. true is returned if the cancellation is successful or if the report is repeatedly canceled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Canceled")]
        [Validation(Required=false)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// <para>The ID of the SQL pattern comparison report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1B2C3D-4E5F-6789-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
