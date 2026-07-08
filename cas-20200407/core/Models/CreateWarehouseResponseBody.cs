// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateWarehouseResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0206B77-14B9-584C-8A3A-09D5827FBC50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The instance ID of the certificate warehouse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-wh-typ-serial</para>
        /// </summary>
        [NameInMap("WarehouseInstanceId")]
        [Validation(Required=false)]
        public string WarehouseInstanceId { get; set; }

    }

}
