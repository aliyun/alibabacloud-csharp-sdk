// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTenantBindNumberRequest : TeaModel {
        /// <summary>
        /// <para>The bound number (required).</para>
        /// <remarks>
        /// <para>Queries the binding status of the specified number across all instances. Obtain the number from the response parameters of ListAllTenantBindNumberBinding.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15005059355</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

    }

}
