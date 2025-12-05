// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteClientKeyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the client key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KAAP.66abf237-63f6-4625-b8cf-47e1086e****</para>
        /// </summary>
        [NameInMap("ClientKeyId")]
        [Validation(Required=false)]
        public string ClientKeyId { get; set; }

    }

}
