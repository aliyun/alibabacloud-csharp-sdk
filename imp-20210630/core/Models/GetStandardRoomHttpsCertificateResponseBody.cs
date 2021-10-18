// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetStandardRoomHttpsCertificateResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetStandardRoomHttpsCertificateResponseBodyResult Result { get; set; }
        public class GetStandardRoomHttpsCertificateResponseBodyResult : TeaModel {
            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }
        };

    }

}
