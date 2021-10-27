// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ListUserReportsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("sqlComparisonReport")]
        [Validation(Required=false)]
        public ListUserReportsResponseBodySqlComparisonReport SqlComparisonReport { get; set; }
        public class ListUserReportsResponseBodySqlComparisonReport : TeaModel {
            [NameInMap("SqlPassFailNum")]
            [Validation(Required=false)]
            public long? SqlPassFailNum { get; set; }
            [NameInMap("SqlPassRate")]
            [Validation(Required=false)]
            public string SqlPassRate { get; set; }
            [NameInMap("SqlPassSuccNum")]
            [Validation(Required=false)]
            public long? SqlPassSuccNum { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("executeDetailList")]
            [Validation(Required=false)]
            public ListUserReportsResponseBodySqlComparisonReportExecuteDetailList ExecuteDetailList { get; set; }
            public class ListUserReportsResponseBodySqlComparisonReportExecuteDetailList : TeaModel {
                [NameInMap("executeDetail")]
                [Validation(Required=false)]
                public List<ListUserReportsResponseBodySqlComparisonReportExecuteDetailListExecuteDetail> ExecuteDetail { get; set; }
                public class ListUserReportsResponseBodySqlComparisonReportExecuteDetailListExecuteDetail : TeaModel {
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    [NameInMap("ExecDetailMsg")]
                    [Validation(Required=false)]
                    public string ExecDetailMsg { get; set; }

                    [NameInMap("Execute")]
                    [Validation(Required=false)]
                    public string Execute { get; set; }

                    [NameInMap("SqlContent")]
                    [Validation(Required=false)]
                    public string SqlContent { get; set; }

                }

            }
        };

    }

}
