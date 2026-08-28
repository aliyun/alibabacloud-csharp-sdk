// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetPatrolReportDetailRequest : TeaModel {
        /// <summary>
        /// <para>The report date in ISO format such as 2026-08-13, or a special value such as today or yesterday. Specify either this parameter or reportId. This parameter is used to retrieve the latest report for the specified date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260416</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The report ID. Specify either this parameter or date. The reportId parameter takes priority over the date parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d72edfd9f3ef475ca310456ecdb09fe8</para>
        /// </summary>
        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The time zone. Used together with the date parameter. Default value: UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTC</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
