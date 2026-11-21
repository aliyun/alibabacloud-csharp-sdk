// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetCmsServiceRequest : TeaModel {
        /// <summary>
        /// <para>prometheus: the activation status of the Prometheus service (billed based on the amount of reported or written data).</para>
        /// 
        /// <b>Example:</b>
        /// <para>prometheus</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>prometheus: indicates whether the Prometheus product billed based on the amount of reported data is activated.
        /// prometheusgb: indicates whether the Prometheus product billed based on the amount of written data is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prometheus</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
