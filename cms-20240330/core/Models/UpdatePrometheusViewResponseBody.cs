// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdatePrometheusViewResponseBody : TeaModel {
        /// <summary>
        /// <para>Prometheus view instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-xxxxxx</para>
        /// </summary>
        [NameInMap("prometheusViewId")]
        [Validation(Required=false)]
        public string PrometheusViewId { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D964F5-76C7-19A2-9399-457744AB3619</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
