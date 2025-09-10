// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreatePrometheusViewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cd5237f7dbd574cf9bbd648ff9efb16cd</para>
        /// </summary>
        [NameInMap("prometheusViewId")]
        [Validation(Required=false)]
        public string PrometheusViewId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
