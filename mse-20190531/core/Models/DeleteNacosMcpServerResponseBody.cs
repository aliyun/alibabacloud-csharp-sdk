// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteNacosMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0DB055C-51F2-5BB2-82A6-CD8A3C6EE6BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
