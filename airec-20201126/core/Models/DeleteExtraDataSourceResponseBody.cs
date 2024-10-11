// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DeleteExtraDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B90B646-1678-41A3-B23F-EAC6587B0E48</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>返回参数。</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ExtraDataSource Result { get; set; }

    }

}
