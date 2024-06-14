// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// The SSL setting of the OceanBase cluster instance.
        /// </summary>
        [NameInMap("InstanceSSL")]
        [Validation(Required=false)]
        public ModifyInstanceSSLResponseBodyInstanceSSL InstanceSSL { get; set; }
        public class ModifyInstanceSSLResponseBodyInstanceSSL : TeaModel {
            /// <summary>
            /// The operation to modify the SSL status. Valid values:
            /// 
            /// - open: Enable SSL encryption.
            /// 
            /// - update: Update the CA certificate.
            /// 
            /// - close: Disable SSL encryption.
            /// </summary>
            [NameInMap("EnableSSL")]
            [Validation(Required=false)]
            public string EnableSSL { get; set; }

            /// <summary>
            /// The ID of the OceanBase cluster.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
