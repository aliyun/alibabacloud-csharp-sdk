// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteBackendRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27be0dd9ebbc467b9e86c0d250d0b92e</para>
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
