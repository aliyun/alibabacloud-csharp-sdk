// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsSqlAuditStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsSqlAuditStatusResponseBodyData Data { get; set; }
        public class DescribeDrdsSqlAuditStatusResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDrdsSqlAuditStatusResponseBodyDataData> Data { get; set; }
            public class DescribeDrdsSqlAuditStatusResponseBodyDataData : TeaModel {
                public string ExtraSlsLogStore { get; set; }
                public string DbName { get; set; }
                public string Detailed { get; set; }
                public bool? ExtraWriteEnabled { get; set; }
                public string Enabled { get; set; }
                public long? ExtraAliUid { get; set; }
                public string ExtraSlsProject { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
