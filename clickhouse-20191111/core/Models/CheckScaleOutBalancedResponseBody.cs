// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckScaleOutBalancedResponseBody : TeaModel {
        [NameInMap("CheckCode")]
        [Validation(Required=false)]
        public string CheckCode { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TableDetails")]
        [Validation(Required=false)]
        public CheckScaleOutBalancedResponseBodyTableDetails TableDetails { get; set; }
        public class CheckScaleOutBalancedResponseBodyTableDetails : TeaModel {
            [NameInMap("TableDetail")]
            [Validation(Required=false)]
            public List<CheckScaleOutBalancedResponseBodyTableDetailsTableDetail> TableDetail { get; set; }
            public class CheckScaleOutBalancedResponseBodyTableDetailsTableDetail : TeaModel {
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public int? Detail { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        [NameInMap("TimeDuration")]
        [Validation(Required=false)]
        public string TimeDuration { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
