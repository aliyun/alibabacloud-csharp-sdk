// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyInstanceSSLRequest : TeaModel {
        /// <summary>
        /// The operation to modify the SSL status. Valid values:
        /// 
        /// - open: Enable SSL encryption.
        /// 
        /// - update: Update the CA certificate.
        /// 
        /// - close: Disable SSL encryption.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public string EnableSSL { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
