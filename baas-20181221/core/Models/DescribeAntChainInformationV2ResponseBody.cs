// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainInformationV2ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainInformationV2ResponseBodyResult Result { get; set; }
        public class DescribeAntChainInformationV2ResponseBodyResult : TeaModel {
            [NameInMap("AbnormalNodes")]
            [Validation(Required=false)]
            public int? AbnormalNodes { get; set; }

            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

            [NameInMap("BlockHeight")]
            [Validation(Required=false)]
            public int? BlockHeight { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("IsRole")]
            [Validation(Required=false)]
            public bool? IsRole { get; set; }

            [NameInMap("NodeInfos")]
            [Validation(Required=false)]
            public List<DescribeAntChainInformationV2ResponseBodyResultNodeInfos> NodeInfos { get; set; }
            public class DescribeAntChainInformationV2ResponseBodyResultNodeInfos : TeaModel {
                [NameInMap("BlockHeight")]
                [Validation(Required=false)]
                public long? BlockHeight { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("NodeNumber")]
            [Validation(Required=false)]
            public int? NodeNumber { get; set; }

            [NameInMap("Normal")]
            [Validation(Required=false)]
            public bool? Normal { get; set; }

            [NameInMap("TransactionSum")]
            [Validation(Required=false)]
            public int? TransactionSum { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
