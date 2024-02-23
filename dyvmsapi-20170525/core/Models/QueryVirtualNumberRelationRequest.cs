// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVirtualNumberRelationRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The virtual number.
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        /// <summary>
        /// The service name. Default value: **dyvms**.
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// The qualification ID.
        /// 
        /// You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Qualifications\&Communication Scripts > Qualification Management**, and then click **Details** in the Actions column to view the qualification ID.
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// The city to which the virtual number belongs.
        /// </summary>
        [NameInMap("RegionNameCity")]
        [Validation(Required=false)]
        public string RegionNameCity { get; set; }

        /// <summary>
        /// The real number.
        /// </summary>
        [NameInMap("RelatedNum")]
        [Validation(Required=false)]
        public string RelatedNum { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The route type. Valid values:
        /// 
        /// **0**: number location first. **1**: random.
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public int? RouteType { get; set; }

        /// <summary>
        /// The number type. Valid values:
        /// 
        /// *   **1**: the number provided by a virtual network operator, in the 05710000\*\*\*\* format.
        /// *   **2**: the number provided by an Internet service provider (ISP).
        /// *   **3**: a 5-digit phone number that starts with 95.
        /// </summary>
        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public long? SpecId { get; set; }

    }

}
