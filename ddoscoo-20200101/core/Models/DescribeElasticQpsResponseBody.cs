// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticQpsResponseBody : TeaModel {
        [NameInMap("ElasticQps")]
        [Validation(Required=false)]
        public List<DescribeElasticQpsResponseBodyElasticQps> ElasticQps { get; set; }
        public class DescribeElasticQpsResponseBodyElasticQps : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("MaxNormalQps")]
            [Validation(Required=false)]
            public long? MaxNormalQps { get; set; }

            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            [NameInMap("Status2")]
            [Validation(Required=false)]
            public long? Status2 { get; set; }

            [NameInMap("Status3")]
            [Validation(Required=false)]
            public long? Status3 { get; set; }

            [NameInMap("Status4")]
            [Validation(Required=false)]
            public long? Status4 { get; set; }

            [NameInMap("Status5")]
            [Validation(Required=false)]
            public long? Status5 { get; set; }

            [NameInMap("Ups")]
            [Validation(Required=false)]
            public long? Ups { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
