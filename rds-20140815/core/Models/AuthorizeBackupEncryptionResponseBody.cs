// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AuthorizeBackupEncryptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization status of the account. Valid values:</para>
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
        public int? AuthorizationState { get; set; }

        /// <summary>
        /// <para>The error message returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create backup encrypt service linked role error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A1DD2A4-69F7-5848-AD56-********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Resource Name (ARN) of the service-linked role associated with backup encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::113991************:role/AliyunServiceRoleForRdsBackupEncryption</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

    }

}
