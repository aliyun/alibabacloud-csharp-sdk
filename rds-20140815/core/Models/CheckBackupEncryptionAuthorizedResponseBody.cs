// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckBackupEncryptionAuthorizedResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the account is authorized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Not authorized.</description></item>
        /// <item><description>1: Authorized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthorizationState")]
        [Validation(Required=false)]
        public string AuthorizationState { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB07C463-7428-50AA-9E39-********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Resource Name (ARN) of the service-linked role associated with Cloud Hardware Security Module (CloudHSM) for backup encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1139916************:role/AliyunServiceRoleForRdsBackupEncryption</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

    }

}
