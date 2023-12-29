// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyStatisticPublicRequest : TeaModel {
        /// <summary>
        /// The verification method. Valid values:
        /// 
        /// *   **1**: one-click logon
        /// *   **2**: phone number verification, including the verification of the phone number used in HTML5 pages
        /// *   **3**: SMS verification
        /// *   **4**: facial recognition
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public int? AuthenticationType { get; set; }

        /// <summary>
        /// The end date. Specify this parameter in the YYYYMMDD format. Example: 20220106.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The type of the operating system. Valid values:
        /// 
        /// *   **Android**
        /// *   **iOS**
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The service code.
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// The start date. Specify this parameter in the YYYYMMDD format. Example: 20220101.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
