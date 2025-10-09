// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeSiteTimeSeriesDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metric to query.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<DescribeSiteTimeSeriesDataRequestFields> Fields { get; set; }
        public class DescribeSiteTimeSeriesDataRequestFields : TeaModel {
            /// <summary>
            /// <para>The dimensions at which you want to query the data.</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public List<string> Dimension { get; set; }

            /// <summary>
            /// <para>The metric to query.</para>
            /// <remarks>
            /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/2878520.html">Data analysis field description</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Traffic</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1150376036*****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
