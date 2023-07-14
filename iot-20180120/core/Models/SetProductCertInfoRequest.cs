// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SetProductCertInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.****
        /// 
        /// >  If your instance has an ID, you must specify the ID for the parameter. Otherwise, the call fails. If no Overview page or ID is generated for your instance, you do not need configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The source from which the X.509 certificate is issued.
        /// 
        /// *   **1**: The X.509 certificate is issued by IoT Platform.
        /// *   **3**: The X.509 certificate is issued by a third-party platform.
        /// </summary>
        [NameInMap("IssueModel")]
        [Validation(Required=false)]
        public int? IssueModel { get; set; }

        /// <summary>
        /// The **ProductKey** of the product.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
