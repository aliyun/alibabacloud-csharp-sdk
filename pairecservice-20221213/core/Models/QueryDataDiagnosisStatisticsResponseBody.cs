// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryDataDiagnosisStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public QueryDataDiagnosisStatisticsResponseBodyStatistics Statistics { get; set; }
        public class QueryDataDiagnosisStatisticsResponseBodyStatistics : TeaModel {
            [NameInMap("FailedDates")]
            [Validation(Required=false)]
            public List<string> FailedDates { get; set; }

            [NameInMap("NoDataDates")]
            [Validation(Required=false)]
            public List<string> NoDataDates { get; set; }

        }

    }

}
