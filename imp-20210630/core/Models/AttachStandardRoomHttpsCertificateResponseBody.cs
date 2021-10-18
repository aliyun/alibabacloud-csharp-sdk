// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AttachStandardRoomHttpsCertificateResponseBody : TeaModel {
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
        public AttachStandardRoomHttpsCertificateResponseBodyResult Result { get; set; }
        public class AttachStandardRoomHttpsCertificateResponseBodyResult : TeaModel {
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }
        };

    }

}
