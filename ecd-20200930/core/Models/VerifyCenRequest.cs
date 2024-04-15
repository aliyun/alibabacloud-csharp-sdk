// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class VerifyCenRequest : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The Alibaba Cloud account to which the CEN instance belongs.
        /// 
        /// *   If you own the CEN instance, you can skip this parameter.
        /// *   If you do not own the CEN instance, you must specify the ID of the account that owns the CEN instance.
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// The IPv4 CIDR block of the associated office network.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The verification code. If you do not own the CEN instance, you must call the [SendVerifyCode](~~436847~~) operation to obtain a verification code.
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
