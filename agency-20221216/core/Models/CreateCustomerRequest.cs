// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCustomerRequest : TeaModel {
        /// <summary>
        /// <para>The customer name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DoorBell Marketing</para>
        /// </summary>
        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// <para>The customer source.
        /// Use the Customer Source enumeration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>website</para>
        /// </summary>
        [NameInMap("CustomerSource")]
        [Validation(Required=false)]
        public string CustomerSource { get; set; }

        /// <summary>
        /// <para>The customer sub-industry.
        /// Use the Customer Sub Trade enumeration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020501</para>
        /// </summary>
        [NameInMap("CustomerSubTrade")]
        [Validation(Required=false)]
        public string CustomerSubTrade { get; set; }

        /// <summary>
        /// <para>The customer industry name.
        /// Use the Customer Trade enumeration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0205</para>
        /// </summary>
        [NameInMap("CustomerTrade")]
        [Validation(Required=false)]
        public string CustomerTrade { get; set; }

        /// <summary>
        /// <para>The region to which the customer belongs. Call ListCountries to obtain the list of available regions for the current UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AR</para>
        /// </summary>
        [NameInMap("Nation")]
        [Validation(Required=false)]
        public string Nation { get; set; }

    }

}
