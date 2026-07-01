// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class DeleteSmsSignRequest : TeaModel {
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
        /// <para>The SMS signature. You can delete signatures that are in the Withdrawn, Failed, or Approved state. You cannot delete signatures that are in the Pending Approval state.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/419282.html">QuerySmsSignList</a> operation to query the signatures that have been applied for under the current account, or view the signature list on the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Signature Management</a> page in the SMS console.</para>
        /// <remarks>
        /// <para>Notice: Deleted SMS signatures cannot be recovered, and the signature can no longer be used to send SMS messages. Proceed with caution.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

    }

}
