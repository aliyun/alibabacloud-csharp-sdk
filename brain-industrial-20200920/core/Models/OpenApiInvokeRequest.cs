// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class OpenApiInvokeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>119397</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;a&quot;:{&quot;value&quot;:1}}</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>215168378e7b43789cabeef1d0db9320</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
