// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortFlowListResponseBody : TeaModel {
        [NameInMap("PortFlowList")]
        [Validation(Required=false)]
        public List<DescribePortFlowListResponseBodyPortFlowList> PortFlowList { get; set; }
        public class DescribePortFlowListResponseBodyPortFlowList : TeaModel {
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            [NameInMap("InPps")]
            [Validation(Required=false)]
            public long? InPps { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SlaBpsDropBps")]
            [Validation(Required=false)]
            public long? SlaBpsDropBps { get; set; }

            [NameInMap("SlaBpsDropPps")]
            [Validation(Required=false)]
            public long? SlaBpsDropPps { get; set; }

            [NameInMap("SlaConnDropBps")]
            [Validation(Required=false)]
            public long? SlaConnDropBps { get; set; }

            [NameInMap("SlaConnDropPps")]
            [Validation(Required=false)]
            public long? SlaConnDropPps { get; set; }

            [NameInMap("SlaCpsDropBps")]
            [Validation(Required=false)]
            public long? SlaCpsDropBps { get; set; }

            [NameInMap("SlaCpsDropPps")]
            [Validation(Required=false)]
            public long? SlaCpsDropPps { get; set; }

            [NameInMap("SlaPpsDropBps")]
            [Validation(Required=false)]
            public long? SlaPpsDropBps { get; set; }

            [NameInMap("SlaPpsDropPps")]
            [Validation(Required=false)]
            public long? SlaPpsDropPps { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
