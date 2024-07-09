// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GrantRoleToUsersRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the role.
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("userArns")]
        [Validation(Required=false)]
        public List<string> UserArns { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
