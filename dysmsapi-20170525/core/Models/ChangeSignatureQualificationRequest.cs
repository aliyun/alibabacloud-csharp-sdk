// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ChangeSignatureQualificationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the authorization letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000********1234</para>
        /// </summary>
        [NameInMap("AuthorizationLetterId")]
        [Validation(Required=false)]
        public long? AuthorizationLetterId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the qualification, which is returned when you apply for it. You can also find this ID on the <a href="https://dysms.console.aliyun.com/domestic/text/qualification">Qualification Management</a> page in the console for messages to the Chinese mainland.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1*****2</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The signature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("SignatureName")]
        [Validation(Required=false)]
        public string SignatureName { get; set; }

    }

}
