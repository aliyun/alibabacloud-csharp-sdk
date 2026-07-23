// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryDataDiagnosisStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics for the data diagnosis task.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public QueryDataDiagnosisStatisticsResponseBodyStatistics Statistics { get; set; }
        public class QueryDataDiagnosisStatisticsResponseBodyStatistics : TeaModel {
            /// <summary>
            /// <para>The dates of task failures.</para>
            /// </summary>
            [NameInMap("FailedDates")]
            [Validation(Required=false)]
            public List<string> FailedDates { get; set; }

            /// <summary>
            /// <para>The dates with missing task data.</para>
            /// </summary>
            [NameInMap("NoDataDates")]
            [Validation(Required=false)]
            public List<string> NoDataDates { get; set; }

        }

    }

}
