// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UnbindLicenseProductRequest : TeaModel {
        /// <summary>
        /// The ID of the Enterprise Edition instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The license type that specifies the audio and video specifications. Valid values: **480P** and **720P**.
        /// 
        /// To view the license type of a product, choose **License Management > Product Authorization** in the **Real-time Communication Service** console.
        /// </summary>
        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

        /// <summary>
        /// The ProductKey of the product from which you want to unbind the license.
        /// 
        /// You can choose **License Management > Product Authorization** in the **Real-Time Communication Service** console to view the **ProductKey** of the product.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
