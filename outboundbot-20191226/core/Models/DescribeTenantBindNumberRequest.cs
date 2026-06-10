// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeTenantBindNumberRequest : TeaModel {
        /// <summary>
        /// <para>Phone number to query (required)</para>
        /// <remarks>
        /// <para>Query the binding status of this number across all instances. Get the number from the response of ListAllTenantBindNumberBinding.</para>
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
