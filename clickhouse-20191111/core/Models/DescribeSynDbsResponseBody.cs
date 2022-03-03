// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSynDbsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SynDbs")]
        [Validation(Required=false)]
        public List<DescribeSynDbsResponseBodySynDbs> SynDbs { get; set; }
        public class DescribeSynDbsResponseBodySynDbs : TeaModel {
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("RdsId")]
            [Validation(Required=false)]
            public string RdsId { get; set; }

            [NameInMap("RdsPassword")]
            [Validation(Required=false)]
            public string RdsPassword { get; set; }

            [NameInMap("RdsUserName")]
            [Validation(Required=false)]
            public string RdsUserName { get; set; }

            [NameInMap("RdsVpcUrl")]
            [Validation(Required=false)]
            public string RdsVpcUrl { get; set; }

            [NameInMap("SynDb")]
            [Validation(Required=false)]
            public string SynDb { get; set; }

            [NameInMap("SynStatus")]
            [Validation(Required=false)]
            public bool? SynStatus { get; set; }

        }

    }

}
