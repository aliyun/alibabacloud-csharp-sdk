// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainInformationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainInformationResponseBodyResult Result { get; set; }
        public class DescribeAntChainInformationResponseBodyResult : TeaModel {
            [NameInMap("TransactionSum")]
            [Validation(Required=false)]
            public int? TransactionSum { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("BlockHeight")]
            [Validation(Required=false)]
            public int? BlockHeight { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("NodeNumber")]
            [Validation(Required=false)]
            public int? NodeNumber { get; set; }
            [NameInMap("AbnormalNodes")]
            [Validation(Required=false)]
            public int? AbnormalNodes { get; set; }
            [NameInMap("NodeInfos")]
            [Validation(Required=false)]
            public List<DescribeAntChainInformationResponseBodyResultNodeInfos> NodeInfos { get; set; }
            public class DescribeAntChainInformationResponseBodyResultNodeInfos : TeaModel {
                public bool? Status { get; set; }
                public string NodeName { get; set; }
                public string Version { get; set; }
                public long? BlockHeight { get; set; }
            }
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }
            [NameInMap("Normal")]
            [Validation(Required=false)]
            public bool? Normal { get; set; }
        };

    }

}
