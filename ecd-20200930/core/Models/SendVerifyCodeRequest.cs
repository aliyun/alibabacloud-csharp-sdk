// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SendVerifyCodeRequest : TeaModel {
        /// <summary>
        /// The information in JSON format that is required for sending the verification code. To verify the security of CEN, you must provide the ID of the CEN instance and the ID of the Alibaba Cloud account to which the instance belongs.
        /// 
        /// *   CenId: the ID of the CEN instance
        /// *   CenOwnerId: the ID of the Alibaba Cloud account to which the CEN instance belongs.
        /// 
        /// Note: If you specify the CenId parameter and the CEN instance that you specify for the CenId parameter belongs to the Alibaba Cloud account, skip this parameter. If you specify the CenId parameter and the CEN instance that you specify for the CenId parameter belongs to another Alibaba Cloud account, enter the ID of the exact Alibaba Cloud account. Example: {"cenOwnerId": 1234567890\*\*\*\*\*\*,"cenId": "cen-3weq30r6t0s7t4\*\*\*\*"}.
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The action that indicates what the verification code is used for. The parameter is only used to verify the security of CEN. Valid value: eds_cenID_securityverification.
        /// </summary>
        [NameInMap("VerifyCodeAction")]
        [Validation(Required=false)]
        public string VerifyCodeAction { get; set; }

    }

}
