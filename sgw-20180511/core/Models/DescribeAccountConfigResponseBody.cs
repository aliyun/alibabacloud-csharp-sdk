// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeAccountConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSupportClientSideEncryption")]
        [Validation(Required=false)]
        public bool? IsSupportClientSideEncryption { get; set; }

        [NameInMap("IsSupportElasticGatewayBeta")]
        [Validation(Required=false)]
        public bool? IsSupportElasticGatewayBeta { get; set; }

        [NameInMap("IsSupportGatewayLogging")]
        [Validation(Required=false)]
        public bool? IsSupportGatewayLogging { get; set; }

        [NameInMap("IsSupportServerSideEncryption")]
        [Validation(Required=false)]
        public bool? IsSupportServerSideEncryption { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
