// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class DeleteMmsDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2000015</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public long? Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EA1320AB-7766-5EC7-B0F6-8B20E2298567</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
