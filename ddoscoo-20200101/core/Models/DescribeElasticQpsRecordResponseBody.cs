// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticQpsRecordResponseBody : TeaModel {
        [NameInMap("ElasticQpsList")]
        [Validation(Required=false)]
        public List<DescribeElasticQpsRecordResponseBodyElasticQpsList> ElasticQpsList { get; set; }
        public class DescribeElasticQpsRecordResponseBodyElasticQpsList : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("OpsElasticQps")]
            [Validation(Required=false)]
            public long? OpsElasticQps { get; set; }

            [NameInMap("OpsQps")]
            [Validation(Required=false)]
            public long? OpsQps { get; set; }

            [NameInMap("OriginQps")]
            [Validation(Required=false)]
            public long? OriginQps { get; set; }

            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            [NameInMap("QpsPeak")]
            [Validation(Required=false)]
            public long? QpsPeak { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
