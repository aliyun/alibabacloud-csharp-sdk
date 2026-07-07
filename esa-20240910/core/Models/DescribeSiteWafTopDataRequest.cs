// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeSiteWafTopDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Specify the time in ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The query metrics.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<DescribeSiteWafTopDataRequestFields> Fields { get; set; }
        public class DescribeSiteWafTopDataRequestFields : TeaModel {
            /// <summary>
            /// <para>The query dimension.</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public List<string> Dimension { get; set; }

            /// <summary>
            /// <para>The query metric value.</para>
            /// <remarks>
            /// <para>For specific dimensions, see <a href="https://help.aliyun.com/document_detail/2878520.html">Data analytics field description</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Requests</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        /// <summary>
        /// <para>The time granularity for querying data. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The number of top data entries to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>If this parameter is left empty, user-level data is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1150376036*****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
