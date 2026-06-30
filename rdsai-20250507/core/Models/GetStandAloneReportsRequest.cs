// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetStandAloneReportsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the query\&quot;s time range. The time must be in UTC and in the <c>YYYY-MM-DDTHH:mm:ssZ</c> format. If omitted, no end time filter is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-19T02:20:20Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default: 20. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The start of the query\&quot;s time range. The time must be in UTC and in the <c>YYYY-MM-DDTHH:mm:ssZ</c> format. If omitted, no start time filter is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T02:09:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
