// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetCmsServiceRequest : TeaModel {
        /// <summary>
        /// <para>prometheus: Checks the activation status of the Prometheus service. The service is billed by reported data volume or written data volume.</para>
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
        /// <para>prometheus: Checks whether the Prometheus product that is billed by reported data volume is activated.prometheusgb: Checks whether the Prometheus product that is billed by written data volume is activated.</para>
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
