// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateExtCodeSignRequest : TeaModel {
        /// <summary>
        /// <para>要修改的扩展码A3</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("ExistExtCode")]
        [Validation(Required=false)]
        public string ExistExtCode { get; set; }

        /// <summary>
        /// <para>修改后的扩展码A3</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("NewExtCode")]
        [Validation(Required=false)]
        public string NewExtCode { get; set; }

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
        /// <para>签名</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

    }

}
