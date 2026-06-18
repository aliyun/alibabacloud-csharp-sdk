// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteCustomHostnameRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom hostname. To obtain this ID, call the <a href="https://help.aliyun.com/document_detail/3018667.html">ListCustomHostnames</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("HostnameId")]
        [Validation(Required=false)]
        public long? HostnameId { get; set; }

    }

}
