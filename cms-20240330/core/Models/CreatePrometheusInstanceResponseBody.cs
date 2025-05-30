// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreatePrometheusInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rw-abc123</para>
        /// </summary>
        [NameInMap("prometheusInstanceId")]
        [Validation(Required=false)]
        public string PrometheusInstanceId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-BE6E-5F82-A484-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
