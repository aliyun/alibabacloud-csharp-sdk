// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterReportDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The report ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KS2YE3J2</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}
