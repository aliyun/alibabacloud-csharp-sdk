// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DeleteModelOperatorApiKeyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API key to delete. The value must be an integer greater than 0. You can obtain the ID by calling ListModelOperatorApiKeys.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApiKeyId")]
        [Validation(Required=false)]
        public int? ApiKeyId { get; set; }

    }

}
