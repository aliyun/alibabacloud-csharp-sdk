// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModulePriceMapValue : TeaModel {
        /// <summary>
        /// <para>The price, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        /// <summary>
        /// <para>The service number, such as a flight number or train number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MU1234</para>
        /// </summary>
        [NameInMap("service_no")]
        [Validation(Required=false)]
        public string ServiceNo { get; set; }

    }

}
