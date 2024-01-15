// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AttachCenRequest : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the CEN instance belongs.
        /// 
        /// *   If the CEN instance specified by CenId belongs to the current Alibaba Cloud account, you can skip this parameter.
        /// *   If the CEN instance specified by CenId belongs to another Alibaba Cloud account, you must specify this parameter.
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The region ID of the workspace.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The verification code. If the CEN instance that is specified by CenId belongs to another Alibaba Cloud account, you must call the SendVerifyCode operation to obtain the verification code.
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
