/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleRequest : TeaModel {
        /// <summary>
        /// The validity period of the STS token. Unit: seconds.
        /// 
        /// Minimum value: 900. Maximum value: the value of the `MaxSessionDuration` parameter. Default value: 3600.
        /// 
        /// You can call the CreateRole or UpdateRole operation to configure the `MaxSessionDuration` parameter. For more information, see [CreateRole](~~28710~~) or [UpdateRole](~~28712~~).
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// The external ID of the RAM role.
        /// 
        /// This parameter is provided by an external party and is used to prevent the confused deputy problem.
        /// 
        /// The value must be 2 to 1,224 characters in length and can contain letters, digits, and the following special characters: `= , . @ : / - _`. The regular expression for this parameter is `[\w+=,.@:\/-]*`.
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The policy that specifies the permissions of the returned STS token. You can use this parameter to grant the STS token fewer permissions than the permissions granted to the RAM role.
        /// 
        /// *   If you specify this parameter, the permissions of the returned STS token are the permissions that are included in the value of this parameter and owned by the RAM role.
        /// *   If you do not specify this parameter, the returned STS token has all the permissions of the RAM role.
        /// 
        /// The value must be 1 to 2,048 characters in length.
        /// 
        /// For more information about policy elements and sample policies, see [Policy elements](~~93738~~) and [Overview of sample policies](~~210969~~).
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the RAM role.
        /// 
        /// The trusted entity of the RAM role is an Alibaba Cloud account. For more information, see [Create a RAM role for a trusted Alibaba Cloud account](~~93691~~) or [CreateRole](~~28710~~).
        /// 
        /// Format: `acs:ram::<account_id>:role/<role_name>`.
        /// 
        /// You can view the ARN in the RAM console or by calling operations. The following items describe the validity periods of storage addresses:
        /// 
        /// *   For more information about how to view the ARN in the RAM console, see [How do I find the ARN of the RAM role?](~~39744~~)
        /// *   For more information about how to view the ARN by calling operations, see [ListRoles](~~28713~~) or [GetRole](~~28711~~).
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// The custom name of the role session.
        /// 
        /// Set this parameter based on your business requirements. In most cases, you can set this parameter to the identity of the API caller. For example, you can specify a username. You can specify `RoleSessionName` to identify API callers that assume the same RAM role in ActionTrail logs. This allows you to track the users that perform the operations.
        /// 
        /// The value must be 2 to 64 characters in length and can contain letters, digits, and the following special characters: `. @ - _`.
        /// </summary>
        [NameInMap("RoleSessionName")]
        [Validation(Required=false)]
        public string RoleSessionName { get; set; }

    }

}
