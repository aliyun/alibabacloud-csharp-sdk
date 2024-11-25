// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GrantRoleToUsersRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:emr::w-975bcfda9625****:role/Owner</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The user ARNs.</para>
        /// </summary>
        [NameInMap("userArns")]
        [Validation(Required=false)]
        public List<string> UserArns { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
