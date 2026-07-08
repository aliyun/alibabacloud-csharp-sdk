// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CancelOrderRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. Use this ID to troubleshoot and locate problems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>082FAB35-6AB9-4FD5-8750-D36673548E76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
