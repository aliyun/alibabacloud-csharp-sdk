// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCustomerRequest : TeaModel {
        /// <summary>
        /// <para>Customer\&quot;s name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DoorBell Marketing</para>
        /// </summary>
        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// <para>The source/channel that allow client to connected with us. Please enumerate with Customer Source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>website</para>
        /// </summary>
        [NameInMap("CustomerSource")]
        [Validation(Required=false)]
        public string CustomerSource { get; set; }

        /// <summary>
        /// <para>The sub-industry that Customer\&quot;s business belongs to. Please enumerate with Customer Trade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0101</para>
        /// </summary>
        [NameInMap("CustomerSubTrade")]
        [Validation(Required=false)]
        public string CustomerSubTrade { get; set; }

        /// <summary>
        /// <para>The industry that Customer\&quot;s business belongs to. Please enumerate with Customer Trade.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("CustomerTrade")]
        [Validation(Required=false)]
        public string CustomerTrade { get; set; }

        /// <summary>
        /// <para>The region that Customer choose to launch the Cloud Service. Please use ListCountries to confirm the valid region list for current UID.</para>
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
