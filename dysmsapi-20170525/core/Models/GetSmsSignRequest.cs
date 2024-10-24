// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsSignRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Signature name. Must be an SMS signature already applied for by this account.</para>
        /// <list type="bullet">
        /// <item><description>Obtain from the return parameters after calling the <a href="https://help.aliyun.com/zh/sms/developer-reference/api-dysmsapi-2017-05-25-createsmssign?spm">CreateSmsSign</a> API.</description></item>
        /// <item><description>View the signature on the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Signature Management</a> page.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

    }

}
