// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogTypeDistributionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeList")]
        [Validation(Required=false)]
        public List<GetLogTypeDistributionResponseBodyTimeList> TimeList { get; set; }
        public class GetLogTypeDistributionResponseBodyTimeList : TeaModel {
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("ExecCostUS")]
            [Validation(Required=false)]
            public string ExecCostUS { get; set; }

            [NameInMap("InsertSqlCount")]
            [Validation(Required=false)]
            public int? InsertSqlCount { get; set; }

            [NameInMap("SelectSqlCount")]
            [Validation(Required=false)]
            public int? SelectSqlCount { get; set; }

            [NameInMap("DeleteSqlCount")]
            [Validation(Required=false)]
            public int? DeleteSqlCount { get; set; }

            [NameInMap("BeginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            [NameInMap("OtherSqlCount")]
            [Validation(Required=false)]
            public int? OtherSqlCount { get; set; }

            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public int? SqlCount { get; set; }

            [NameInMap("UpdateSqlCount")]
            [Validation(Required=false)]
            public int? UpdateSqlCount { get; set; }

        }

    }

}
