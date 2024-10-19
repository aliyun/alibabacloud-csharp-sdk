// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class BatchAbolishApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f7834d74be4e41aa8e607b0fafae9b33</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7FE7172-AA75-5880-B6F7-C00893E9BC06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
